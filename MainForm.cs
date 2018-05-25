using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace DiscreteDeviceAssigner
{
    using Microsoft.HyperV.PowerShell;
    using Microsoft.Management.Infrastructure;
    using DeviceData = Tuple<Microsoft.HyperV.PowerShell.VirtualMachine,
Microsoft.HyperV.PowerShell.VMAssignedDevice>;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //更新虚拟机和设备显示
        private void UpdateVM()
        {
            listView1.Groups.Clear();
            listView1.Items.Clear();

            //获取虚拟机列表
            var vms = PowerShellWrapper.GetVM();
            var groups = new List<ListViewGroup>();
            foreach (var vm in vms)
            {
                ListViewGroup group = new ListViewGroup("[" + vm.State + "]" + vm.Name);
                groups.Add(group);
            }

            //获取每个虚拟机下设备列表
            var lviss = new List<ListViewItem>[vms.Count];
            Parallel.For(0, vms.Count, (int i) => {
                var vm = vms[i];
                var group = groups[i];
                lviss[i] = new List<ListViewItem>();
                var lvis = lviss[i];

                foreach (var dd in PowerShellWrapper.GetVMAssignableDevice(vm))
                {
                    var dev = PowerShellWrapper.GetPnpDevice(dd.InstanceID);
                    //string name = dev.CimInstanceProperties["Name"] != null ? dev.CimInstanceProperties["Name"].Value as string : null;
                    string name = dd.Name;
                    string clas = dev.CimInstanceProperties["PnpClass"] != null ? dev.CimInstanceProperties["PnpClass"].Value as string : null;
                    lvis.Add(new ListViewItem(new string[] { name != null ? name : "", clas != null ? clas : "", dd.LocationPath }, group)
                    {
                        Tag = new DeviceData(vm, dd),
                    });
                }
                lvis.Add(new ListViewItem("...", group)
                {
                    Tag = new DeviceData(vm, null),
                });
            });

            //更新ListView
            listView1.BeginUpdate();
            foreach (var group in groups)
            {
                listView1.Groups.Add(group);
            }
            foreach (var lvis in lviss)
            {
                foreach (var lvi in lvis)
                {
                    listView1.Items.Add(lvi);
                }
            }
            listView1.EndUpdate();
        }

        //加载事件
        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            UpdateVM();
        }

        //呼出右键菜单
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    DeviceData data = listView1.SelectedItems[0].Tag as DeviceData;
                    contextMenuStrip.Tag = data;
                    contextMenuStrip.Items[0].Text = data.Item1.Name;
                    contextMenuStrip.Show(sender as Control, e.Location);
                }
            }
        }

        //右键菜单呼出事件
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            DeviceData data = contextMenuStrip.Tag as DeviceData;
            if (data.Item2 == null)
            {
                移除设备ToolStripMenuItem.Enabled = false;
                复制地址toolStripMenuItem.Enabled = false;
            }
            else
            {
                移除设备ToolStripMenuItem.Enabled = true;
                复制地址toolStripMenuItem.Enabled = true;
            }
            uint lowMMIO = 0;
            try
            {
                //这句会莫名其妙抛出异常
                lowMMIO = data.Item1.LowMemoryMappedIoSpace;
            }
            catch { }
            LMMIOtoolStripTextBox.Text = (lowMMIO / 1024 / 1024).ToString();
            HMMIOtoolStripTextBox.Text = (data.Item1.HighMemoryMappedIoSpace / 1024 / 1024).ToString();
            GCCTtoolStripMenuItem.Checked = data.Item1.GuestControlledCacheTypes;
        }

        //添加设备
        private void 添加设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData data = contextMenuStrip.Tag as DeviceData;
            CimInstance dev = new PnpDeviceForm().GetResult();
            if (dev != null)
            {
                string name = dev.CimInstanceProperties["Name"] != null ? dev.CimInstanceProperties["Name"].Value as string : null;
                if (name == null) name = "";
                if (MessageBox.Show("确定添加设备“" + name + "”到虚拟机“" + data.Item1.Name + "”吗？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        PowerShellWrapper.AddVMAssignableDevice(data.Item1, dev);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误");
                    }
                    UpdateVM();
                }
            }
        }

        //移除设备
        private void 移除设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData data = contextMenuStrip.Tag as DeviceData;
            if (MessageBox.Show("确定从虚拟机“" + data.Item1.Name + "”移除设备“" + data.Item2.Name + "”吗？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PowerShellWrapper.RemoveVMAssignableDevice(data.Item1, data.Item2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
                UpdateVM();
            }
        }

        //复制地址
        private void 复制地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData data = contextMenuStrip.Tag as DeviceData;
            Clipboard.SetText(data.Item2.LocationPath);
        }

        //刷新列表
        private void 刷新列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateVM();
        }

        //GuestControlledCacheTypes
        private void GCCTtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData data = contextMenuStrip.Tag as DeviceData;
            try
            {
                PowerShellWrapper.SetGuestControlledCacheTypes(data.Item1, !GCCTtoolStripMenuItem.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        //HighMemoryMappedIoSpace
        private void HMMIOtoolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeviceData data = contextMenuStrip.Tag as DeviceData;
                ulong mb;
                if (ulong.TryParse(HMMIOtoolStripTextBox.Text, out mb))
                {
                    var vm = data.Item1;
                    ulong bytes = mb * 1024 * 1024;
                    if (bytes != vm.HighMemoryMappedIoSpace && bytes != 0)
                    {
                        try
                        {
                            PowerShellWrapper.SetHighMemoryMappedIoSpace(vm, bytes);
                            //Success
                            contextMenuStrip.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "错误");
                        }
                    }
                }

                //Failed
                HMMIOtoolStripTextBox.Text = (data.Item1.HighMemoryMappedIoSpace / 1024 / 1024).ToString();
            }
        }

        //LowMemoryMappedIoSpace
        private void LMMIOtoolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DeviceData data = contextMenuStrip.Tag as DeviceData;
                uint mb;
                if (uint.TryParse(LMMIOtoolStripTextBox.Text, out mb))
                {
                    var vm = data.Item1;
                    uint bytes = mb * 1024 * 1024;
                    uint lowMMIO = 0;
                    try
                    {
                        //这句会莫名其妙抛出异常
                        lowMMIO = data.Item1.LowMemoryMappedIoSpace;
                    }
                    catch { }
                    if ((lowMMIO == 0 || bytes != lowMMIO) && bytes != 0)
                    {
                        try
                        {
                            PowerShellWrapper.SetLowMemoryMappedIoSpace(vm, bytes);
                            //Success
                            contextMenuStrip.Close();
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "错误");
                        }
                    }
                }

                //Failed
                LMMIOtoolStripTextBox.Text = (data.Item1.LowMemoryMappedIoSpace / 1024 / 1024).ToString();
            }
        }
    }
}

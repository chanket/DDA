## What's This
实现Hyper-V设备离散设备分配（DDA）的图形界面工具，该功能于Windows Server 2016 TP4加入。DDA可以用于将类PCI设备（GPU、网络适配器等）直通虚拟机，使虚拟机具有对物理设备的直接控制权。DDA只能通过Powershell命令完成，这个工具以这些命令为基础实现，并提供了图形界面。
A GUI tool for Hyper-V's Discrete Device Assignment(DDA), which is supported since Windows Server 2016 TP4. DDA can be used to pass-through PCI-like devices(GPU, network adapter, etc.) to virtual machines, making the VM have direct access to the physical device. DDA can only be achieved by Powershell commandlines; this tool is based on these commands and provides a GUI.

## Reference
https://blogs.technet.microsoft.com/virtualization/2015/11/19/discrete-device-assignment-description-and-background/
https://blogs.technet.microsoft.com/virtualization/2015/11/20/discrete-device-assignment-machines-and-devices/
https://blogs.technet.microsoft.com/virtualization/2015/11/23/discrete-device-assignment-gpus/
https://blogs.technet.microsoft.com/virtualization/2015/11/24/discrete-device-assignment-guests-and-linux/

## Tested OS
Windows Server 2016. 

## Language
目前只支持简体中文。
CHS at present only.

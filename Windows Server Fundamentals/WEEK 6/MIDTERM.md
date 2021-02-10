## MIDTERM

MIS 273:  Midterm

Market:  Windows Server Fundamentals

Name:

Directions:  Answer the questions below in your own words and upload in the appropriate section in Canvas.

Your writing (in total) should be approximately two written pages of response (not counting any graphical documentation / screenshots, where relevant).

Note: The numbering indicates the origin of the question (i.e. C01 content is from Chapter 1, C07: content is in Chapter 7, etc. within the Microsoft Official Academic Course (MOAC)).

___________________________________________________________________


C01: Windows Server 2016

Describe some of the most common features or uses of Windows Server 2016 and their intended use.  In particular, make note of features that you believe are most commonly used in Small to Medium Enterprises (SME).

When you mention the service, make note of its purpose and function.  Also note how you would add the service / enable it on the server operating system.

Answer C01:

Windows server is a operating system that allows a computer to handle network roles/services such as being a web server, file server, domain controller, or print server. These roles are often built in functions in windows server and are easily installed through the main server controller called "server manager". Other services require outside download and install but are the same as any windows system. Its similarity allows for a much easier setup and use, along with being familiar to most people. It is also a great platform to for separate server applications like SQL server.
___________________________________________________________________


C02: Installing, Upgrading, and Migrating Servers as Workloads

Describe (at a high level), the big picture steps that are needed to Install Windows Server 2016.

Consider in your process that you are describing the installation process to someone that has never installed Windows Server (2016).  You may make reference to end user desktop operating systems as an example in order to introduce a newer user to common installation procedure(s).

Answer C02:

First the most important step for installing windows server is getting the actual software. After this you need to load it into the computer through USB, Disk, or other methods. Then when the computer starts jump into the bios and select that software from USB, Disk, or what you are using and make it a boot drive. Then exit bios while saving those changes and wait for the computer to boot from that new software. After this its very simple, and actually much easier then regular windows if you are just doing a basic install. One important note is that you are prompted to select what kind of windows server you want to install, desktop experience or command line. Then you have can select a basic install or custom, and then you select what drive you want to select to install windows server on.  Then there are accouple straight forward questions like what you want your user name, password, etc. to be and you are done.
___________________________________________________________________


C03: Configuring Disks and Volumes

Indicate how you would add disks to your Windows Server if it is a Virtual Machine.

You can reference your hypervisor of choice (i.e. VMware, Hyper-V, VirtualBox, etc.).  Said differently, your references, do not need to be bound to using Hyper-V. You can provide examples using whatever Virtualization solution / hypervisor that you prefer.

Answer C03:

When you are in the VirtualBox interface you select the installed virtual server with windows server on it and then you select settings. After this you go into storage and at the bottom of the middle you will see the add new storage controller. Then select the add hard drive option and select the drive that you want on your pc.
___________________________________________________________________


C07: Installing and Configuring Hyper-V

Indicate the purpose of Hyper-V and how it (as well as other virtualization solutions) can be used to host Server operating systems.

What (if any) advantages do you see that Hyper-V has other solutions?  

What (if any) drawbacks / deficits do you feel that Hyper-V may have in comparison to other hypervisors / virtualization solutions?

Answer C07:

Hyper-V is a type 1 hypervisor that manages operating systems by running directly on hardware. Hyper-V offers high performance virtual machines, and can output a lot of power depending on the hardware that it is running on.  Additionally, since Hyper-V is a type 1 hypervisor, virtual machines are always running as long as the hardware is.  Hyper-V also integrates well with Windows, and is simple to use once it has been implemented, as the virtual machines run as long as the hardware is running, but it isn’t as easy to set up as Oracle VM VirtualBox, which is a simple installation for most users.  

Also, while Hyper-V is great for people using Windows host systems that want to run Windows servers, Hyper-V can’t handle non-Windows operating systems.
___________________________________________________________________


Overall:  Virtualization

What overall benefits do you feel that virtualization offers?

What overall drawbacks do you feel virtualization suffers from (if any)?

If you were deploying a server in production, what are your perspectives thus far as to whether you would choose to install directly on the hardware or in a virtual machine.

Explain why you would elect one install type (hardware vs. virtualized / virtual “hardware”) over the other.

Its easy to say that virtualization is the better option just from a IT aspect. The use of virtual systems are easy to manage and can be scaled much easier then having hardware systems that only have one operating system on them. This also enables a better price because you don't have to have multiple systems if you need multiple operating systems. Efficiency is also a key part of virtualization because you can divide system resources between machines. So if you have hardware that has unused resources during single operating systems use you can divide those idle resources to another operating system.

The only possible downside that I can think of is that if you have multiple systems on one piece of hardware then if something fails that is more then one operating system that will fail. This could be solved with clusters but for simple virtualization I could see it being a problem.
__________________________________________________________________

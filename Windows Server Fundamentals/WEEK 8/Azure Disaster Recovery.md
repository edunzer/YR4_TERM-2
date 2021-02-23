## AZURE DISASTER RECOVERY

Design and document a strategy for implementing Azure Disaster Recovery (site recovery). There is no software installation or configuration involved in this assignment. You are to write up a plan/strategy for disaster recovery. Assume you’re part of an organization that has decided to use Azure Disaster Recovery for backup, virtual machine replication, and if/when necessary will use Azure Site Recovery. Before continuing, view the videos specified for this week in Canvas.

Include each of the following items in your strategy:

    - Specify the number of virtual machines and their function in your scenario. You must have at least 4 virtual machines. For example one could be a web server, another could be a file server, etc.

    - Location of your virtual machines such as Azure, Amazon Web Services or your own site.

    - RPO (you’ll find the meaning of this acronym in the videos)

    - RTO (you’ll find the meaning of this acronym in the videos)

    - What virtual machines have two or more instances in the same availability set

    - Type of storage: LRS or GRS (you’ll find the meaning of these acronyms in the videos)

    - How you will protect your passphrase that would be used for restoring backups. Also be sure to specify how you’ll ensure that this passphrase is not lost so that it will be available if needed.

    - What Azure “Protection Procedures” (backup solutions) you’ll use. You must specify at least four including “Create a Recovery Services vault” and “Protect Azure virtual machines”. Specify the reason for using each of the “Protection Procedures” you select. See the video called “Azure Backup protection solutions”.

    - Specify what your backup policies will be. See the video called “Create a Recovery Services vault” for more information.

    - Specify how to get to the backups and where they are located (multiple locations)

    - Specify the replication frequency you would use. See the video called “Overview of Azure Site Recovery”.

    - For the recovery plan part of your strategy, specify what machines are grouped together and for the failover and start stages or even any machines will start before others in the recovery. See the video called “Create a Recovery Plan”. 

    - Document the initial steps to get someone started to perform a site recovery if/when one is necessary.


At the end of your document, answer these questions:

    - Why isn’t replicating a virtual machine considered an appropriate backup? See the video called “Protect an Azure virtual machine”.

    - When would you install the Azure Backup Server? See the video called “Installing the Azure Backup Server”.


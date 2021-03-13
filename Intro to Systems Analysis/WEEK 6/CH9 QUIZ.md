## CH9 QUIZ
Question 1
6 / 6 pts
Show that you understand the differences and similarities between functional and non-functional requirements. Provide clear examples of each that demonstrates your understanding. <400 words

Your Answer:
  Functional requirements define the basic system behavior. Basically, they are what the system does or does not do, and can be seen in terms of how the system responds to inputs. Functional requirements usually define if/then behaviors and include calculations, data input, and business processes.

      Functional requirements are features that allow the system to function as it was intended. Put another way, if the functional requirements are not met, the system will not work. Functional requirements are product features and focus on user requirements.

      So an example of a non-functional requirement would be "A Verification email is sent to user whenever he/she registers for the first time on some software system." This is something that must happen in order to fulfill the requirements of the system.

    While functional requirements define what the system does or must not do, non-functional requirements specify how the system should do it. Non-functional requirements do not affect the basic functionality of the system. Even if the non-functional requirements are not met, the system will still perform its basic purpose.

      Non-functional requirements define system behavior, features, and general characteristics that affect the user experience. How well non-functional requirements are defined and executed determines how easy the system is to use, and is used to judge system performance. Non-functional requirements are product properties and focus on user expectations.

      So an example of a non-functional requirement could that "emails should be sent with a latency of no greater than 12 hours from such an activity". This is not a metric that measures the basic functionality of the system but instead how efficient it is. It is non-functional to have a fast system because if the system was slow it would still be functional.

 
Question 2
6 / 6 pts
Provide a comprehensive definition of the term 'architecture' as used in Chapter 9. Choose one of the TOGAF framework architectures to use as an example to show the elements of a system architecture

Your Answer:
  The book describes architecture According to Merriam-Webster, where he states that “architecture is the conscious act of determining the optimal form and structure of a system.” But after this definition they go on to say that one of the purposes of architecture is to reduce complexity and minimize the harmful impact of a high level of complexity when it cannot be reduced. Architecture also provides general, broadly applicable guidance to those who plan, design, procure, configure, and construct organizational systems. 

  They also state that software architecture as a set of decisions regarding issues that are both important and difficult to change after the initial decision is made. Many architectural decisions create dependencies on a particular approach or way of thinking in a way that locks the organization into the chosen architecture. There is no way to avoid these dependencies, but it is essential to know when and where long-term commitments are made and what the dependencies are. Architectural work helps us understand these issues.

  Business architecture which is one of the kinds of TOGAF architects, deals with key high-level decisions regarding the business. This includes strategy, organizational structure, governance, and foundational business processes. A Business Architect interprets and contextualizes strategy for operational needs, develops specific artifacts such as business capability maps and value streams to help bridge the gap between strategy and execution, and helps streamline and justify the IT processes.

 
Question 3
4 / 4 pts
From Section 9.4.2.5 of the text, discuss the advantages and disadvantages of both horizontal and vertical scaling. 

Your Answer:
  In horizontal scaling, a system is grown by increasing the number of units that provide computing services, whereas in vertical scaling, the system grows by increasing the capacity of existing computing devices. Both have their advantages and disadvantages. In horizontal scaling, one of the challenges is the increased software complexity—dividing a computing task between multiple units is not a trivial task and may lead to incorrect results if done incorrectly. Also, separate computing units are typically connected by a network, and a network is always slower compared to communication within one processing unit. Furthermore, horizontal scaling needs load balancing between the computing units.

    Vertical scaling often cannot be done gradually—growing vertically literally means buying a new, significantly bigger unit. It also has the problem of creating a single point of failure; a horizontally scaled system distributes the tasks between multiple units, and if that is done well, the loss of a computing unit is not fatal to the system. Finally, vertical growth has its limits; in very large systems with potentially millions of users, even a very large single computer cannot handle the load.

    Horizontal scaling: Increasing the capacity of a system by increasing the number of units that provide computing services.

    Vertical scaling: Increasing the capacity of a system by increasing the capacity of existing computing devices.

 
Question 4
3.5 / 4 pts
Pick 2 of the models from the FURPS+ models in Section 9.3 and why they would be a good choice for describing non-functional requirements. Give a clear example of each. 

Your Answer:
  Usability: usability refers to the characteristics of the system that determine the users’ experience with the system and particularly its interface, affecting the users’ effectiveness, efficiency, and satisfaction with the system. 

      - Level of user expertise assumed.
      - User interface standards used.
      - Documentation provided.

  For example, a system that requires too many repetitive user actions to be efficient and accurate enough is not usable.

  Supportability: Essentially, it deals with those system characteristics that specify how easy it is to adapt the system to changing circumstances and fix various types of problems with the system. 

      - How will system be extended?
      - Who maintains the system?

  For example, a system that is very difficult to alter when faced with external change is not supportable.

## ESSAY QUIZ: CHAPTER 14 CONCEPTS 

1: Explain the key idea underlying the separation of concerns principle.

    The Separation of Concerns Principle deals with the way in which computer programs and systems are supposed to be designed in separate distinct sections that address a certain concern. The concern would be a problem that the code block/section would solve. For example in a program that turns a word into pig latin there needs to be a block/section of code that takes in the specified word. Then that block passes that information into another block in charge of turning it into pig latin. The Separation of Concerns Principle allows for more degrees of freedom when it comes to the designing and working with a program. Most commonly noted when separating codes into blocks is the easy ability to maintain and update said code since you know where all the specific parts are that concern one issue. An example of the concerns principle is webpage design or at least basic webpage design where different languages are used for different elements of the webpage. Html is the main construction and organization of the webpage, css is the styling and look or "presentation", and the javascript is how often interaction between the webpage and the user or the webpage and data sources. 

2: Describe how the separation of concerns principle is aligned with the layered model.

    In a way separation of concerns principle and the layered model are very similar in there implementation. Both have a divided approach where different sections are awarded for different topics to help organize everything. The layer model takes this idea and puts it into an application model where each layer has to do with a specific part of the application and then there are more sections in each of those layers. Each of those sections in the layers have to do with the separation of concerns principle. The layered model has 4 different layers presentation, business, persistence, and database. In some cases, the business layer and persistence layer are combined into a one business layer, mostly when the persistence layer is embedded within the business layer components.

    Every one of the layers has a specific role towards the application. For example, a presentation layer would be responsible for handling all user interface and browser communication logic, whereas a business layer would be responsible for executing specific business rules associated with the request. Each of these layers deals only with one area of the application and makes sure that work is satisfied in that concept. For example, the presentation layer doesn’t need  get customer data; it only needs to display that information. Similarly, the business layer doesn’t need to know about displaying customer data; it only needs to get the data from the persistence layer perform its function and then pass that data to the presentation layer.  

    One important part of the layered model is that all requests have to go through all the layers in order. This is put in place so that all layers have access to the information being passed from the first layer and have the ability to stop it if there is a problem. When this is the case the layers are labeled closed and can only be accessed through the step by step layered approach. Now in certain instances there are layers that are labeled open and can be bypassed but this is only when a layer does not have significant impact on the data being written or retrieved. Think of it as a addon to only work in certain defined instances that are rarely used. 

3: Explain what we mean when we state that a domain model can be used as a foundation for multiple different types of logical data models (and, consequently, database implementations)?

    A Domain model is the all encompassing model that covers a specific defined domain. This means that inside that domain are all representations of what is meaningful in that domain and what is relevant. So it is only natural that with this model which defines what the domain is/needs that data models can be created from it using the data representing in the domain model. The data that would be represented in the domain model would pertain to that domain instance and therefore have similar language to the data models that would be created from it. Often the domain models contain values and definitions for different data inside of them. All of these definitions and requirements then can be used in defining data modeling and later on there implementations of that data in a database. 

4: Describe the differences between the system sequence diagram and design sequence diagram.

    A System Sequence Diagram is a sequence diagram that shows the events that their order, involve actors, and possible inter-system events of a particular scenario of a use case. It is tasked with knowing communication objects, human actors, objects and actor lifelines, requests and responses. These components allow for the diagram to show communication patterns and protocols between various parties in a structured communication situation. It can be used to model communication scenarios that are unexplored and need to be defined. The communication can be between humans, computers, or humans and computers. The System Sequence Diagrams main purpose is to capture interaction and put that interaction into a use case format for later use. System Sequence Diagrams are represented in a timeline format to so progression through the different interactions. 

    A Design Sequence Diagram is a diagram which shows the detailed interactions between classes and their methods within a system. There main job is the capture the interaction between objects in the sequence that have interaction. So instead of communication events between a humans, computers, or humans and computers it is interaction between events in the systems methods. 

    The difference between the two is simple. A System Sequence Diagram is the all encompassing diagram that visualizes a use case. It defines the main interaction events between the users and then explains what happens after said reactions. A Design Sequence Diagram visualizes the methods of a class inside of the system sequence diagram. So instead of seeing the entire user case in a timeline this diagram see's only a specific interaction instance where a method of the sequence diagram is created.  

    








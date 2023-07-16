Principio de inversión de la dependencia
• Existen 3 tipos de inyección de dependencia
 - constructor
 - propiedad
 - parámetro
• Dependencia por constructor es la más común

Singleton Scope:
The Singleton scope is a commonly used scope in dependency injection frameworks. It means that only one instance of a particular dependency is created and shared throughout the application. Whenever the dependency is requested, the same instance is returned. This is useful when you want to share the same object across multiple components.

Scope:
The concept of scopes in dependency injection frameworks allows you to define the lifecycle and visibility of objects. Different frameworks may have different terminologies for scopes, such as request scope, session scope, etc. Scopes determine how long an object lives and when it should be created or destroyed. For example, a request scope would create a new instance of an object for each incoming request, while a session scope would create a new instance for each user session.

Transient:
The term "transient" is not directly related to dependency injection, but it is often used in the context of object creation and lifecycle management. A transient object is an object that is short-lived and has no particular scope. It is created whenever needed and typically discarded after its immediate use. In the context of dependency injection, a transient object would be created whenever it is injected into a dependent component and not reused.
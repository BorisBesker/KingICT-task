# KingICT-task

In the Tickets context there is whole application structure, as an example how the projects shuld be defined(losse coupling, modularity, separation of concerns), and all the dependencies between them. Also in the ticket context are producers and messages class, in other contexts these things are omited (you can see it on the design picture how to communaction looks like) and also for not knowing in depth what certain business events need to be potentialy shared accross apps.

![image](https://github.com/BorisBesker/KingICT-task/assets/26566198/ab34fd70-6189-4613-89be-33716d68a29b)

In the classes in tickets context every class has comments about functionality, reason from them etc.... Also in consumers classes

![image](https://github.com/BorisBesker/KingICT-task/assets/26566198/f6f641c0-7cb6-4e18-b91d-fe56b5325897)

Every context that needs to share infomartion across diferent contexts has to have Business event log table => represent the events that need to be shared, a separate table because of potential multiple operations that are changing state in db(ticket purchase => ticket cancelation) => in that way we have all the history of the state => in case broker servers goes down, fails .. etc => it has retry mechanizam so everything is stored.

If an app in some context needs information "now" from app in different context an API can be exposed(synchronous communication).

The contexts it's self severs also that teams can work independetly one from another.

## Design

![systemdesignnew](https://github.com/BorisBesker/KingICT-task/assets/26566198/99008710-5b9b-4c75-9d21-d1353764bb8d)



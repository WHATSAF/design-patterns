# 桥接
* 采用组合的关联关系取代继承，组合的耦合度比继承低，实现了低耦合的目标

**关键点**
- *定义实现化角色（要组合对象的抽象）抽象与具体角色*
- *定义抽象化角色（最终目标的抽象），包含对实现化角色的引用，具体抽象化实现角色继承抽象化角色*
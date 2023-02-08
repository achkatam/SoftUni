## SOLID Principles

### 1.[S]ingle Responsibility
### 2.[O]pen/Closed
### 3.[L]iskov Subtitution
### 4.[I]nterface Sagregation 
### 5.[D]ependancy Inversion

# 1.1. Single Responsibility 
- Every class should be responsible for **only a single part of the functionality** and that **responsibility** should be **entirely encapsulated** by the class!
# 1.2. Strong Cohesion -
- Refers to the grouping of functionality related processes into a particular module.
1.2.1. Each task maps a single code unit.
1.2.2. A method should do one operation.
1.2.3. A class should represent one entity

# 1.3. Loose Coupling
- the degree of dependance between modules - The strength of relationship between modules.

## Example: 
- In Amazon you can find phone case with bottle opener. Does not even make sense. That BREAKS the principle!

# 2.1. Open/Closed 
 - Software entities like **classes, modules and functions** should be **OPEN** for extension and **CLOSED** for modification.
 
 ## Example:
 - You own an IPhone. Its OS is **closed** for modification for you but it's **open** for extension via AppStore for example. That extends its base functionality and capability of the base phone - you can play games, take pics, videos and etc. 

# 3.1. Liskov Subtitution
- Derived types /child classes/ should be entirely subtituable for their base types /parent classes/

## Example:
- You make a cake. Unfortunartely you are out of sugar. You can use cane sugar instead.

# 4.1. Interface Segregation
- Segregate to smaller and more specific interfaces. **No code should be forced to depend on methods it does NOT use**.

## Example:
- https://medium.com/@ipapikas/solid-series-4-5-interface-segregation-principle-8e901d189428

# 5.1. Dependancy Inversion
- High-level module should **NOT** depend on low-level module, both depend on abstratcion. Abstraction should **NOT** depend on details. Details depend on abstraction.

5.2.
1.Client - the Main class/code that runs the high-level module.
2.High-level module - The interface/abstraction that your client uses.
3.Low-level module - Details of your interface/abstraction.

**BREAK-Down**
Let's use a **car** for example. You have a car.
1.Client - You as the person driving the car.
2.High-lvl module - The steering wheel and gas/brakes pedals to drive the car.
3.Low-level module - The engine.
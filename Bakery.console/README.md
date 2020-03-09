# _Pierre's Bakery C# Console App_

#### _This is a sample app that will allow a user to browse Pierre's Bakery bread and pastry deals and add items to their cart. | Fab 28. 2020_

#### By _**Dusty McCord**_

## Description

This is a simple C# sharp console application. It was built as a Friday independent project for Epicodus. It shows the bread and pastry offerings for the fictional Pierre's Bakery and allows the user to add items to a cart. 

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._
_Make sure you have [.Net Core 2.2 installed](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed on your computer._

1. Find the green 'Clone or Download' button and copy the link
2. Open terminal and type...

**Windows**
```sh 
cd desktop
```

 Mac & linux 
 ```sh
 cd ~/Desktop
 ```

 3. In terminal type '_git clone {link to repository}_ '

```sh
git clone https://github.com/dustatron/Csharp-Bakery-Console-app.git
```

4. Navigate to the new folder that was created from your terminal.
```sh
cd Bakery
```
5. Install dependencies by typing:
```sh
dotnet restore
```
6. Run the program by typing:
```sh
dotnet run
```
8. enjoy this project


## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------|:------:|:------:
The program shows deals on bread and pastry when opened | Open Program | display deals |
The program shows menus to allow a user to select bread menu | 'b' | show bread menu |
The program shows a list of bread loaves and allows a user to add a loaf of bread to their cart | '1' | item added to cart |
The program will allow a user to select the same item again or another item | '2' or '1' | item added to cart |
The program will allow a user to return to main menu from the bread list | 'm' | show main menu |
The program will allow a user to select pastry menu | 'p' | show pastry list |
The program will allow a user to select a pastry option and add it to their cart | '1' | item added to cart |
The program will allow a user to select same item or another and add it to their cart | '1' or '2' | item added to cart |
The program will allow a user to move to main menu from pastry menu | 'm' | display main menu |
The program will allow a user to see all items in cart and total cost | 'c' | display items in cart and total |
The program will allow a user to select checkout and see a full list of items in cart | '1' | show itemized list |
The program will allow a 'buy two get one free' deal | three bread loaves in cart | charge for only 2 |
The program will allow a user navigate to main menu from cart menu | 'm' | display main menu |


## Support 

_The software is provided as is. It might work as expected - or not. Just don't blame me._


## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.Net Core](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro?&ef_id=Cj0KCQiAkePyBRCEARIsAMy5ScuVs7KY0pg4noWIHaLCk5SEgzizWN7QCyWaGqwOkTMnpp2qhH8qUzMaAn10EALw_wcB:G:s&OCID=AID2000725_SEM_Cj0KCQiAkePyBRCEARIsAMy5ScuVs7KY0pg4noWIHaLCk5SEgzizWN7QCyWaGqwOkTMnpp2qhH8qUzMaAn10EALw_wcB:G:s)


### License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

Copyright (c) 2020 **_Dusty McCord_**


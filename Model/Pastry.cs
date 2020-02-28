using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery.Model
{
  class Pasty
  {
    public string PastryType { get; set; }
    public int PastryCount { get; set; }
    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine(@"
      
.______      ___           _______.___________..______     ____    ____ 
|   _  \    /   \         /       |           ||   _  \    \   \  /   / 
|  |_)  |  /  ^  \       |   (----`---|  |----`|  |_)  |    \   \/   /  
|   ___/  /  /_\  \       \   \       |  |     |      /      \_    _/   
|  |     /  _____  \  .----)   |      |  |     |  |\  \----.   |  |     
| _|    /__/     \__\ |_______/       |__|     | _| `._____|   |__|     
                                                                        
.___  ___.  _______ .__   __.  __    __  
|   \/   | |   ____||  \ |  | |  |  |  | 
|  \  /  | |  |__   |   \|  | |  |  |  | 
|  |\/|  | |   __|  |  . `  | |  |  |  | 
|  |  |  | |  |____ |  |\   | |  `--'  | 
|__|  |__| |_______||__| \__|  \______/  
", Color.Cyan);
      string input = Console.ReadLine();
    }
  }

}
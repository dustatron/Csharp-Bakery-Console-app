﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Bakery
{
  class Program
  {
    List<int> cart = new List<int>(5);
    static void Main(string[] args)
    {
            
            Console.WriteLine(@"
===================================================================
  _____ _                    _       ____        _                   
 |  __ (_)                  ( )     |  _ \      | |                  
 | |__) |  ___ _ __ _ __ ___|/ ___  | |_) | __ _| | _____ _ __ _   _ 
 |  ___/ |/ _ \ '__| '__/ _ \ / __| |  _ < / _` | |/ / _ \ '__| | | |
 | |   | |  __/ |  | | |  __/ \__ \ | |_) | (_| |   <  __/ |  | |_| |
 |_|   |_|\___|_|  |_|  \___| |___/ |____/ \__,_|_|\_\___|_|   \__, |
                                                                __/ |
                                                               |___/ 
======================================================================
            ", Color.BlueViolet);

        Console.WriteLine(@"---------------------  [MAIN MENU] -----------------------");
        Console.WriteLine(@"        Bread: Buy 2, get 1 free. A single loaf costs $5.");
        Console.WriteLine(@"        Pastry: Buy 1 for $2 or 3 for $5.");
        Console.WriteLine(@"        Daily Special: Two loafs of wheat for $5.");

        StyleSheet styleSheet = new StyleSheet(Color.Green);
        styleSheet.AddStyle("B[A-Z]*", Color.Red);
        styleSheet.AddStyle("P[A-Z]*", Color.Cyan);
        styleSheet.AddStyle("C[A-Z]*", Color.Yellow);
        styleSheet.AddStyle("D[A-Z]*", Color.White);

        //Menu string
        string Menu = (@"
        | [B] for bread menu           | 
        | [P] for pastry menu          | 
        | [C] to see your cart         |
        | [D] to buy the daily special |
        ");
        //print Menu
        Console.WriteStyled(Menu, styleSheet);
        Console.Write("Enter : ", Color.Green);
        string input = Console.ReadLine().ToLower();

        switch(input)
        {
          case "b":
          break;

          case "p":
          break;

          case "c":
          break;

          case "d":
          break;

          default:
          break;
        }




        }
    }
}
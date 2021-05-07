﻿using static System.Console;
using System.Collections.Generic;
using Widget.App.Interfaces;
using Widget.App.Models;

var widgets =  new List<IWidget> {
    new Rectangle(30, 40, 10, 10),
    new Square(30, 15, 30),
    new Ellipse(300, 200, 100, 150),
    new Circle(300, 1, 1),
    new Textbox(200, 100, "sample text", 5, 5)
};

WriteLine("-------------------------------------------------------");
WriteLine("Requested Drawing");
WriteLine("-------------------------------------------------------");
widgets.ForEach(x => WriteLine(x.Print()));
WriteLine("-------------------------------------------------------");

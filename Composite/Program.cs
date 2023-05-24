

using Composite.Classes;
using Composite.Patterns.Observer;
//--------------Observer

LightElementNode div = new LightElementNode("form");

LightElementNode p1 = new LightElementNode("p");
LightElementNode p2 = new LightElementNode("p");
LightElementNode p3 = new LightElementNode("p");
LightElementNode p4 = new LightElementNode("p");
LightElementNode btn = new LightElementNode("button");

LightTextNode tp1 = new LightTextNode("Vadim");
LightTextNode tp2 = new LightTextNode("Hello");
LightTextNode btn1 = new LightTextNode("Btn");
div.AppendNode(p1);
div.AppendNode(p2);
div.AppendNode(p3);
div.AppendNode(p4);
btn.AppendNode(btn1);

Click click = new Click();
btn.AddEventListener("click",click.ClickMethod);//створення
btn.AddEventListener("click",click.ClickMethod2);//створення
btn.GenerateEvents("click");//уявний клік


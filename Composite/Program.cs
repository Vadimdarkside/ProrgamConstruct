

using Composite.Classes;
using Composite.Classes_Node;
using Composite.Patterns.Observer;
using Composite.Patterns.Template.Lifecycle_hooks;
//--------------Observer
Console.WriteLine("///////Observer///////---------------------------------------");

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

//--------------Strategy
Console.WriteLine("///////Strategy///////---------------------------------------");

ImgNode img = new ImgNode("C:\\Users\\vadim\\Downloads\\foto\\2.jpg");//any img local
ImgNode img2 = new ImgNode("https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FIMG_%2528company%2529&psig=AOvVaw3XaD6JLz5RVSUwzH30z3KQ&ust=1685050518627000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCLjK5r70jv8CFQAAAAAdAAAAABAE");//web
ImgNode img3 = new ImgNode("eefeefef");//error

Console.WriteLine(img.GetOuterHtml());
Console.WriteLine(img2.GetOuterHtml());
Console.WriteLine(img3.GetOuterHtml());

//--------------Template
Console.WriteLine("///////Template///////---------------------------------------");


LightNode newNode = new NodeTemplateCreatorLog().CreateNode("tag");
Console.WriteLine(newNode.GetOuterHtml());


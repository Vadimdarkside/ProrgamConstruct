

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

Console.WriteLine("//////////////---------------------------------------");

LightElementNode table = new LightElementNode("table");

LightElementNode tr1 = new LightElementNode("tr");
LightElementNode td1 = new LightElementNode("td");
LightElementNode td2 = new LightElementNode("td");
LightElementNode td3 = new LightElementNode("td");

LightElementNode tr2 = new LightElementNode("tr");
LightElementNode td4 = new LightElementNode("td");
LightElementNode td5 = new LightElementNode("td");
LightElementNode td6 = new LightElementNode("td");

LightElementNode tr3 = new LightElementNode("tr");
LightElementNode td7 = new LightElementNode("td");
LightElementNode td8 = new LightElementNode("td");
LightElementNode td9 = new LightElementNode("td");

table.AppendNode(tr1);
tr1.AppendNode(td1);
tr1.AppendNode(td2);
tr1.AppendNode(td3);
table.AppendNode(tr2);
tr2.AppendNode(td4);
tr2.AppendNode(td5);
tr2.AppendNode(td6);
table.AppendNode(tr3);
tr3.AppendNode(td7);
tr3.AppendNode(td8);
tr3.AppendNode(td9);

td1.AppendNode(new LightTextNode("FirstName"));
td2.AppendNode(new LightTextNode("LastName"));
td3.AppendNode(new LightTextNode("Age"));
td4.AppendNode(new LightTextNode("Vadim"));
td5.AppendNode(new LightTextNode("Bondar"));
td6.AppendNode(new LightTextNode("18"));
td7.AppendNode(new LightTextNode("Vadim2"));
td8.AppendNode(new LightTextNode("Bondar2"));
td9.AppendNode(new LightTextNode("20"));

Console.WriteLine("---------------------GetHTMLS");
Console.WriteLine(table.GetOuterHtml());

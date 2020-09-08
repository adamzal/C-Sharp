using System;

public interface IDrawable
{
  void Draw();
}

public class Shape : IDrawable
{
  private string str;
  public Shape(String str)
  {
    this.str = str;
  }
  public virtual void Draw()
  {
    Console.WriteLine(str);
  }
}

public class Circle : Shape, IDrawable
{
  public Circle(String str):base(str){}
  public override void Draw()
  {
    Console.WriteLine("Jestem okręgiem.");
  }
}

public class Rectangle : Shape, IDrawable
{
  public Rectangle(String str):base(str){}
  public override void Draw()
  {
    Console.WriteLine("Jestem prostokątem.");
  }
}

public class Triangle : Shape, IDrawable
{
  public Triangle(String str):base(str){}
  public override void Draw()
  {
    Console.WriteLine("Jestem trójkątem.");
  }
}

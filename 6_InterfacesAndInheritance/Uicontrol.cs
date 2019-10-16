using System;

namespace _6_InterfacesAndInheritance
{
    public class Textbox : Uicontrol, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }
        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class Uicontrol
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}

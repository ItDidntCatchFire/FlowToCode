using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace BaseFlow
{
    public abstract class BaseThumb : Thumb, IThumb
    {
        public abstract ControlTemplate GetControllerTemplate();
        public abstract void _MouseDoubleClick();
        public abstract void _MouseEnter();
        public abstract void _MouseLeave();

        protected BaseThumb()
        {
            DragDelta += _OnDragDelta;

            this.Template = GetControllerTemplate();
            this.ApplyTemplate();
        }


        public void _OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            Thumb1 thumb = e.Source as Thumb1;
            double left = Canvas.GetLeft(thumb) + e.HorizontalChange;
            double top = Canvas.GetTop(thumb) + e.VerticalChange;

            Canvas.SetLeft(thumb, left);
            Canvas.SetTop(thumb, top);
        }
    }



    public class Thumb1 : BaseThumb
    {
        public override ControlTemplate GetControllerTemplate()
        {
            string template = "";

            template += "<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>";
            template += "<StackPanel Name='FRED'>";
            template += "<Ellipse Fill='#FFF4F4F5' Stroke='#FF000000' Width='64' Height='64' Canvas.Left='108' Canvas.Top='121' />";
            template += "<TextBox Height='23' TextWrapping='Wrap' Width='120'/>";


            template += "<TextBlock Text='User stage' Name='tplTextBlock'/>";
            template += "<Button Height='23' Width='120'>new action</Button>";
            template += "</StackPanel>";
            template += "</ControlTemplate>";

            return (ControlTemplate)XamlReader.Parse(template);
        }

        public override void _MouseDoubleClick()
        {
            throw new NotImplementedException();
        }

        public override void _MouseEnter()
        {
            throw new NotImplementedException();
        }

        public override void _MouseLeave()
        {
            throw new NotImplementedException();
        }
    }
}

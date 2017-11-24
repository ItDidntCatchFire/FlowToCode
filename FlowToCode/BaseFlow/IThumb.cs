using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace BaseFlow
{
    interface IThumb
    {
        void _MouseEnter();
        void _MouseLeave();
        void _MouseDoubleClick();
        void _OnDragDelta(object sender, DragDeltaEventArgs e);

        ControlTemplate GetControllerTemplate();

    }
}

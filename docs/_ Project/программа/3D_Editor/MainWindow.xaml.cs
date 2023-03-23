using _3D_Editor.Scene_structure;
using _3D_Editor.Scene;
using _3D_Editor.Project_resources_control;
using _3D_Editor.User_interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3D_Editor
{
    /// <summary>
    /// Функциональная составляющая основного класса программы
    /// </summary>
    public partial class MainWindow : Window
    {
        private Primitives.Primitives        primitives         = null;
        private Modelling.Modelling          modelling          = null;
        private Painting.Painting            painting           = null;
        private Animation.Animation          animation          = null;
        private Scene_structure_controller   scene_structure    = null;
        private Scene_controller             scene              = null;
        private User_interfaces              interfaces         = null;
        private Project_resources_controller project_controller = null;

        /// <summary>
        /// Конструктор класса главного окна
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Init_fields();

            Message();
        }

        /// <summary>
        /// Обеспечивает инициализацию полей класса
        /// </summary>
        private void Init_fields()
        {
            primitives         = new Primitives.Primitives();
            modelling          = new Modelling.Modelling();
            painting           = new Painting.Painting();
            animation          = new Animation.Animation();
            scene_structure    = new Scene_structure_controller();
            scene              = new Scene_controller();
            interfaces         = new User_interfaces();
            project_controller = new Project_resources_controller();
        }

        /// <summary>
        /// Обеспечивает вывод сообщения пользователю, содержащего названия классов полей.
        /// </summary>
        private void Message()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine(primitives        ._class_name);
            message.AppendLine(modelling         ._class_name);
            message.AppendLine(painting          ._class_name);
            message.AppendLine(animation         ._class_name);
            message.AppendLine(scene_structure   ._class_name);
            message.AppendLine(scene             ._class_name);
            message.AppendLine(interfaces        ._class_name);
            message.AppendLine(project_controller._class_name);

            MessageBox.Show(message.ToString());
        }
    }
}

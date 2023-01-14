using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SendImageClient.ViewModels
{
    public class AppViewModel:BaseViewModel
    {
        public SendImageClient.Commands.RelayCommand DragDropCommand { get; set; }
        public AppViewModel()
        {
            DragDropCommand = new SendImageClient.Commands.RelayCommand((args) =>
            {
                var e = args as DragEventArgs;
                ImagePath = null;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    string fileName = System.IO.Path.GetFileName(files[0]);
                    ImagePath = files[0];
                }
            });
        }
    }
}

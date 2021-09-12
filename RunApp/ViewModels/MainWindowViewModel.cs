using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RunApp.ViewModels
{
    [Serializable]
    internal class MainWindowViewModel : ViewModel
    {
        private int rank;
        private string user;
        private string status;
        private int steps;
        private int avgsteps;

        public int Rank
        {
            get { return rank; }
            set => Set(ref rank, value);
        }
        public string User
        {
            get { return user; }
            set => Set(ref user, value);
        }
        public string Status
        {
            get { return status; }
            set => Set(ref status, value);
        }
        public int Steps
        {
            get { return steps; }
            set => Set(ref steps, value);
        }
    }
}

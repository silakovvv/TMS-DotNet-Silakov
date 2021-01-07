using Silakov.Homework5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Silakov.Homework5.Interfaces
{
    public interface IZooManager
    {
        public List<AnimalBase> Animals { get; set; }

        public void WalkingAroundZoo();
    }
}

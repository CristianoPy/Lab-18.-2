using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18._2.Models
{
    internal class Car
    {
        // Id:int
        // Nume
        // Producator
        // Un numar variabil de chei(de la una la oricate)
        // O carte tehnica

        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int? ManufacturerId { get; set; }
        public List<Key>Keys {  get; set; }
        public Manual Manual { get; set; }

    }
}

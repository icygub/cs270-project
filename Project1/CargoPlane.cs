using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    class CargoPlane {

        public CargoPlane(string company, string planeNumber, int mileagePerTank, int seatCapacity, int weightLbsCapacity) {
            this.Company = company;
            this.PlaneNumber = planeNumber;
            this.MileagePerTank = mileagePerTank;
            this.SeatCapacity = seatCapacity;
            this.WeightLbsCapacity = weightLbsCapacity;
        }

        public string Company {
            get; set;
        }

        public string PlaneNumber {
            get; set;
        }

        public int MileagePerTank {
            get; set;
        }

        public int SeatCapacity {
            get; set;
        }

        public int WeightLbsCapacity {
            get; set;
        }
    }
}

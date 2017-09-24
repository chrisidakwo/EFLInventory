using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer {
    public class MeasuringServices {
        public static List<MeasuringType> GetAllMeasuringTypes() {
            return MeasuringProvider.GetAllUnits();
        }

        public static MeasuringType GetMeasuringType(int id) {
            return MeasuringProvider.GetMeasuringType(id);
        }

        public static int AddUpdateMeasuringType(MeasuringType mType) {
            return MeasuringProvider.AddUpdateMeasuringType(mType);
        }
    }
}

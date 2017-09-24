using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public class MeasuringProvider {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public static List<MeasuringType> GetAllUnits() {
            List<MeasuringType> _measuringUnits = new List<MeasuringType>();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                _measuringUnits = db.MeasuringTypes.OrderBy(m => m.name).ToList();
            }

            return _measuringUnits;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MeasuringType GetMeasuringType(int id) {
            MeasuringType mType = new MeasuringType();
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                mType = db.MeasuringTypes.Where(m => m.id == id).FirstOrDefault();
            }

            return mType;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="mType"></param>
        /// <returns></returns>
        public static int AddUpdateMeasuringType(MeasuringType mType) {
            int id = 0;
            using (EFLInventoryContainer db = new EFLInventoryContainer()) {
                if (mType.id > 0) {
                    MeasuringType temp = new MeasuringType() {
                        id = mType.id,
                        name = mType.name,
                    };

                    db.Entry(temp).State = System.Data.EntityState.Modified;
                } else {
                    db.MeasuringTypes.Add(mType);
                }

                db.SaveChanges();
                id = mType.id;
            }

            return id;
        }
    }
}

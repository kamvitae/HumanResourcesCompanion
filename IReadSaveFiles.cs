using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_5_2_HRCompanion
{
    public interface IReadSaveFiles<T> where T : new()
    {
        //na razie niużyty. Jak połączyć <T> w klasie FileHelper z interfacem?
       void SerializeToFile();
       T DeserializeFromFile();
    }
}

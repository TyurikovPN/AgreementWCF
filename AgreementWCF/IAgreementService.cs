using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgreementWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IAgreementService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IAgreementService
    {
        [OperationContract]
        List <Agreements > FindAll();
    }
}

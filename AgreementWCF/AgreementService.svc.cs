using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AgreementWCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "AgreementService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы AgreementService.svc или AgreementService.svc.cs в обозревателе решений и начните отладку.
    public class AgreementService : IAgreementService
    {
        private AgreementEntities ae = new AgreementEntities();
        public List<Agreements> FindAll()
        {
            return ae.Agreements.ToList();
        }
    }
}

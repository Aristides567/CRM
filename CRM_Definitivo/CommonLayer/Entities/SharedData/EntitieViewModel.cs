using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.ViewModel
{
    public class EntitieViewModel
    {
        public SharedData EntitieNow { get; set; }

        public event Action DataUpdate;

        public void UpdateEntities(SharedData answerValues)
        {
            EntitieNow = answerValues;
            DataUpdate?.Invoke();
        }
    }
}

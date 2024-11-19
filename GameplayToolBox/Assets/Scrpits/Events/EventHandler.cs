using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{
    public class EventHandler : MonoBehaviour
    {
        public interface IEvent
        {
            void OnBegin(bool bFirstTime);

            void OnUpdate();
            void OnEnd();

            bool IsDone();
        }

        public class GameEvent : IEvent
        {
            public bool IsDone()
            {
               return true;
            }

            public void OnBegin(bool bFirstTime)
            {
                throw new System.NotImplementedException();
            }

            public void OnEnd()
            {
                throw new System.NotImplementedException();
            }

            public void OnUpdate()
            {
                throw new System.NotImplementedException();
            }
        }

    }

}

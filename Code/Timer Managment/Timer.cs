using System;

namespace Green.Tool.Utility.TimerManagment
{
    public class Timer
    {
        public bool Enabled { get; private set; }

        private float m_Time;
        private float m_CurrentTime;
        private bool m_IsLooped;

        public event Action OnEnd;
        public event Action<Timer> OnRemove;
        
        public Timer(float time, bool isLooped)
        {
            Start(time, isLooped);
        }

        public void Start(float time, bool isLooped)
        {
            if (Enabled == true)
                throw new Exception("");

            m_Time = time;
            m_IsLooped = isLooped;
            Enabled = true;
        }

        public void Pouse()
        {
            if (Enabled == false)
                throw new Exception("");

            Enabled = false;
        }

        public void Continue()
        {
            if (Enabled == true)
                throw new Exception("");

            if (m_Time == 0)
                Stop();

            Enabled = true;
        }

        public void Reset()
        {
            m_CurrentTime = m_Time;
            Enabled = true;
        }

        public void Stop()
        {
            OnRemove?.Invoke(this);
        }

        public void Update(float deltaTime)
        {
            if (Enabled == false)
                return;

            m_CurrentTime -= deltaTime;

            if (m_CurrentTime <= 0)
            {
                OnEnd?.Invoke();

                if (m_IsLooped == true)
                    Reset();
                else
                    Stop();
            }
        }
    }
}
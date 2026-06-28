

namespace signaller_scenario_maker.Objects
{
    public class Train
    {
        public string Name;
        public List<int> Coaches;
        public int CoachLength;
        public float MaxSpeed;
        public float Acceleration;
        public float Deceleration;

        public Train(string name, List<int> coaches, int coachLength, float maxSpeed, float acceleration, float deceleration)
        {
            Name = name;
            Coaches = new List<int>(coaches);
            CoachLength = coachLength;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Deceleration = deceleration;
        }
    }
}

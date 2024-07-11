    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected string _points;

        // Constructors
        public Goal(string shortName, string description, string points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public Goal()
        {

        }

        // Setters

        public void SetName(string shortName)
        {
            _shortName = shortName;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void SetPoints(string points)
        {
            _points = points;
        }

        // Getters

        public string GetName()
        {
            return _shortName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetPoints()
        {
            return _points;
        }

        public abstract void RecordEvent(GoalManager manager);

        public abstract bool IsComplete();

        public virtual string GetDetailString()
        {
            if (IsComplete())
            {
                return $"[X] {_shortName} ({_description})";
            }
            else
            {
                return $"[ ] {_shortName} ({_description})";
            }
        }

        public abstract string GetStringRepresentation();
        public abstract string GetBasicStringRepresentation();
    }
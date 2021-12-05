namespace AdventOfCode2021
{
    public class Day2
    {
        public int Part1(string[] input)
        {
            int x = 0;
            int depth = 0;

            var commands = input.Select(cmd => Day2Command.Parse(cmd));

            foreach (var cmd in commands)
            {
                if (cmd.CommandName == Day2CommandName.Forward)
                {
                    x += cmd.Value;
                } 
                else if (cmd.CommandName == Day2CommandName.Up)
                {
                    depth -= cmd.Value;
                }
                else if (cmd.CommandName == Day2CommandName.Down)
                {
                    depth += cmd.Value;
                }
            }

            return x * depth;
        }

        public int Part2(string[] input)
        {
            int aim = 0;
            int x = 0;
            int depth = 0;

            var commands = input.Select(cmd => Day2Command.Parse(cmd));

            foreach (var cmd in commands)
            {
                if (cmd.CommandName == Day2CommandName.Forward)
                {
                    x += cmd.Value;
                    depth += aim * cmd.Value;
                }
                else if (cmd.CommandName == Day2CommandName.Up)
                {
                    aim -= cmd.Value;
                }
                else if (cmd.CommandName == Day2CommandName.Down)
                {
                    aim += cmd.Value;
                }
            }

            return x * depth;
        }
    }

    public class Day2CommandName
    {
        private Day2CommandName(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static readonly Day2CommandName Forward = new("forward");
        public static readonly Day2CommandName Down = new("down");
        public static readonly Day2CommandName Up = new("up");

        public static Day2CommandName Parse(string commandName)
        {
            return commandName switch
            {
                "forward" => Forward,
                "down" => Down,
                "up" => Up,
                _ => throw new ArgumentOutOfRangeException(nameof(commandName))
            };
        }
    }

    public class Day2Command
    {
        public Day2Command(Day2CommandName commandName, int value)
        {
            CommandName = commandName;
            Value = value;
        }

        public Day2CommandName CommandName { get; }
        public int Value { get; }

        public static Day2Command Parse(string commandInput)
        {
            var commandInputSplit = commandInput.Split(" ");

            return new Day2Command(
                Day2CommandName.Parse(commandInputSplit[0]),
                int.Parse(commandInputSplit[1])
            );
        }
    }
}

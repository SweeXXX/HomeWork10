static class Programm
{
    static void Main()
    {

        var originalString = "BB";

        var ACoder = new ACoder(originalString);

        Console.WriteLine($"Было:{originalString}");
        Console.WriteLine($"ACoder.E:{ACoder.Encode()}");
        Console.WriteLine($"ACoder.D: {ACoder.Decode()}");

        var BCoder = new BCoder(originalString);

        Console.WriteLine($"Было:{originalString}");
        Console.WriteLine($"BCoder.E: {BCoder.Encode()}");
        Console.WriteLine($"BCoder.D: {BCoder.Decode()}");
    }
}

public interface IСoder
{
    string Encode();
    string Decode();
}

public class ACoder : IСoder
{
    private readonly char[] _inputCharArray;

    public ACoder(string inputString)
    {
        _inputCharArray = inputString.ToCharArray();
    }

    public string Decode()
    {
        for (int i = 0; i < _inputCharArray.Length; i++)
        {
            _inputCharArray[i] = (char)(_inputCharArray[i] - 1);
        }

        return string.Join("",_inputCharArray);
    }

    public string Encode()
    {
        for (int i = 0; i < _inputCharArray.Length; i++)
        {
            _inputCharArray[i] = (char)(_inputCharArray[i] + 1);
        }

        return string.Join("", _inputCharArray);
    }
}
public class BCoder : IСoder
{
    private readonly Dictionary<char, Tuple<int, int>> _letters = new Dictionary<char, Tuple<int, int>>();//  символ, начальный диапазон, конечный 

    private readonly char[] _inputCharArray;

    private const int _rAlphabetLength = 32;
    private const int _eAlphabetLength = 26;

    public BCoder(string inputString)
    {
        _inputCharArray = inputString.ToCharArray();

        for (int i = 0; i < _rAlphabetLength; i++)
        {
            _letters.Add((char)(1072 + i), new Tuple<int, int>(1072, 1072 + _rAlphabetLength - 1));
            _letters.Add((char)(1040 + i), new Tuple<int, int>(1040, 1040 + _rAlphabetLength - 1));

            if (i < _eAlphabetLength)
            {
                _letters.Add((char)(97 + i), new Tuple<int, int>(97, 97 + _eAlphabetLength - 1));
                _letters.Add((char)(65 + i), new Tuple<int, int>(65, 65 + _eAlphabetLength - 1));
            }
        }
    }

    public string Encode()
    {
        for (int i = 0; i < _inputCharArray.Length; i++)
        {
            if (_letters.ContainsKey(_inputCharArray[i]))
            {
                var el = _letters[_inputCharArray[i]];
                _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
            }
            else
            {
                _inputCharArray[i] = _inputCharArray[i];
            }
        }
        return string.Concat(_inputCharArray);
    }
    public string Decode()
    {

        for (int i = 0; i < _inputCharArray.Length; i++)
        {
            if (_letters.ContainsKey(_inputCharArray[i]))
            {
                var el = _letters[_inputCharArray[i]];
                _inputCharArray[i] = (char)(el.Item2 - (_inputCharArray[i] - el.Item1));
            }
            else
            {
                _inputCharArray[i] = _inputCharArray[i];
            }

        }
        return string.Concat(_inputCharArray);
    }
}
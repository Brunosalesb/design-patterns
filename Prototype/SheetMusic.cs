namespace Prototype;

public class SheetMusic
{
    private static Dictionary<string, MusicalNote> _noteMap  = new();
	
    public static void LoadNotes() 
    {
        _noteMap["Do"] = new Do();
        _noteMap["Re"] = new Re();
        _noteMap["Mi"] = new Mi();
        _noteMap["Fa"] = new Fa();
        _noteMap["Sol"] = new Sol();
        _noteMap["La"] = new La();
        _noteMap["Si"] = new Si();
    }

    public static MusicalNote? GetNote(string nome)
    {
        if (_noteMap.TryGetValue(nome, out var nota))
            return (MusicalNote)nota.Clone();

        return null;
    }
}
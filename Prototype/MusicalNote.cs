namespace Prototype;

public abstract class MusicalNote : ICloneable
{
	public object Clone()
	{
		return MemberwiseClone();
	}

	public abstract void Draw();
}
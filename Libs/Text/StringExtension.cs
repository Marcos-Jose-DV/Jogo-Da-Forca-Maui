
namespace AppJogoDaForca.Libs.Text;

public static class StringExtension
{
	public static List<int> GetIndexOf(this string str, string value)
	{
		if(String.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value), "String e nula");

		List<int> indexes = new();
		for(int index = 0; ; index += value.Length)
		{
			index = str.IndexOf(value, index);

			if(index == -1) return indexes;

			indexes.Add(index);
		}
	}
}

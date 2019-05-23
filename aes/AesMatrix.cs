using System;

namespace aes
{
  public class AesMatrix
  {
    private byte[,] matrix;
    public AesMatrix(byte[] bytes)
    {
      if (bytes.Length != 16) {
        throw new System.Exception("Quantidade de bytes inválida.");
      }
      this.matrix = new byte[4, 4];
      for(var i = 0; i < bytes.Length; i++)
      {
        this.matrix[i % 4, i / 4] = bytes[i];
      }
    }
    public void Print()
    {
      for(var i = 0; i < this.matrix.Length; i++)
      {
        var row = i % 4;
        var hex = this.matrix[i / 4, row].ToString("X2");
        if (row == 3)
        {
          Console.WriteLine(hex);
        } else 
        {
          Console.Write($"{hex} ");
        }
      }
      Console.WriteLine();
    }
  }
}
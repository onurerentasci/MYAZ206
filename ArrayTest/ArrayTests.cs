using DataStructures.Array;
using Xunit;

namespace ArrayTest
{
    public class ArrayTests
    {
        [Theory] // Fact parametresiz, Theory parametreli
        [InlineData(16)] // 16 l�k dizi olu�tur
        [InlineData(32)] // 32 lik dizi olu�tur
        [InlineData(64)] // 64 l�k dizi olu�tur
        [InlineData(128)] // 128 lik dizi olu�tur
        [InlineData(256)] // 256 l�k test olu�tur
        // default size �zerinden 5 defa test ger�ekle�ir
        public void Check_Array_Constructor(int defaultSize)
        {
            // Arrange | Act
            var arr = new Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, arr.Length);
        }


        [Fact]
        public void Check_Array_Constructor_with_params()
        {
            //Arrange | Act
            var array = new DataStructures.Array.Array(1,2,3); // parantez i�ine yazd���m�z elemenlar dizi uzunlu�unu belirtir
            
            //Assert
            Assert.Equal(3, array.Length); // Arrange | Act k�sm�nda array i�ine verdi�imiz eleman say�s�n� farkl� girdi�imiz taktirde hata al�n�r
        }


        [Fact]
        public void Get_and_Set_Values_in_Array()
        {
            //Arrange
            var array = new DataStructures.Array.Array();

            //Act
            array.SetValue(10, 0);
            array.SetValue(20, 1);

            //Assert
            Assert.Equal(10, array.GetValue(0));
            Assert.Equal(20, array.GetValue(1));
            Assert.Null(array.GetValue(2)); // 2. indexte herhangi bir de�er olmad��� i�in null olur hata vermez

        }

        [Fact]
        public void Array_Clone_Test()
        {
            //Arrange
            var array = new DataStructures.Array.Array(1, 2, 3);

            //Act
            var clonedArray = array.Clone() as DataStructures.Array.Array;

            //Assert
            Assert.NotNull(clonedArray); // ifade refereans alm��
            Assert.Equal(array.Length, clonedArray.Length);
            Assert.NotEqual(array.GetHashCode(), clonedArray.GetHashCode()); // nesneler birbirinden farkl�d�r Equal iddias�nda hata verir
        }


        [Fact]
        public void Array_GetEnumerator_Test()
        {
            //Arrange
            var array = new DataStructures.Array.Array(10,20,30);

            //Act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            //Assert
            Assert.Equal("102030", s);
        }

        [Fact]
        public void Array_Custom_GetEnumerator_Test()
        {
            //Arrange
            var array = new DataStructures.Array.Array(10, 20, 30);

            //Act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            //Assert
            Assert.Equal("102030", s);
        }

    }
}
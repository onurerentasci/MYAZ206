using DataStructures.Array;
using Xunit;

namespace ArrayTest
{
    public class ArrayTests
    {
        [Theory] // Fact parametresiz, Theory parametreli
        [InlineData(16)] // 16 lýk dizi oluþtur
        [InlineData(32)] // 32 lik dizi oluþtur
        [InlineData(64)] // 64 lük dizi oluþtur
        [InlineData(128)] // 128 lik dizi oluþtur
        [InlineData(256)] // 256 lýk test oluþtur
        // default size üzerinden 5 defa test gerçekleþir
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
            var array = new DataStructures.Array.Array(1,2,3); // parantez içine yazdýðýmýz elemenlar dizi uzunluðunu belirtir
            
            //Assert
            Assert.Equal(3, array.Length); // Arrange | Act kýsmýnda array içine verdiðimiz eleman sayýsýný farklý girdiðimiz taktirde hata alýnýr
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
            Assert.Null(array.GetValue(2)); // 2. indexte herhangi bir deðer olmadýðý için null olur hata vermez

        }

        [Fact]
        public void Array_Clone_Test()
        {
            //Arrange
            var array = new DataStructures.Array.Array(1, 2, 3);

            //Act
            var clonedArray = array.Clone() as DataStructures.Array.Array;

            //Assert
            Assert.NotNull(clonedArray); // ifade refereans almýþ
            Assert.Equal(array.Length, clonedArray.Length);
            Assert.NotEqual(array.GetHashCode(), clonedArray.GetHashCode()); // nesneler birbirinden farklýdýr Equal iddiasýnda hata verir
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
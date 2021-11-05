Imports FluentAssertions
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class ChallengesShould
    <TestMethod>
    Public Sub return_mode()
        Dim results = GetMode(1, 2, 3, 3, 4, 4, 5)
        results.Length.Should().Be(2)
        results(0).Should().Be(3)
        results(1).Should().Be(4)
    End Sub

  
    <TestMethod>
    Public Sub return_letter_count()
        Dim resultOne = GetLetterCount("aaaabbbcca")
        resultOne.Should().Be("4a3b2c1a")

        Dim resultTwo = GetLetterCount("ddddddddddd")
        resultTwo.Should().Be("11d")
    End Sub

    <TestMethod>
    Public Sub CallApi()
        Dim result = Challenges.CallApi("apple")

    End Sub
End Class

Module Challenges
    ''' <summary>
    ''' Count the number of times a letter occurs.
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns>Letter Count.</returns>
    Function GetLetterCount(ByVal input As String) As String
        Throw New NotImplementedException()
    End Function
    ''' <summary>
    ''' The number which appears most often in a set of numbers.
    ''' Example: in {6, 3, 9, 6, 6, 5, 9, 3} the Mode is 6 (it occurs most often).
    ''' </summary>
    ''' <param name="numbers"></param>
    ''' <returns>The mode.</returns>
    Function GetMode(ParamArray numbers As Integer()) As Integer()
        Throw New NotImplementedException()
    End Function
    ''' <summary>
    ''' https://dictionaryapi.dev/ 
    ''' for xml http://api.nbp.pl/api/cenyzlota/last/{topCount}
    ''' Call one of the two APIs and cast the response to a strongly typed object 
    ''' </summary>
    ''' <param name="word"></param>
    ''' <returns>Strongly typed object from api response.</returns>
    Function CallApi(ByVal word As String) As Object
        Return Nothing
    End Function
End Module



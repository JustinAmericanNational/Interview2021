Imports System.Net.Http
Imports FluentAssertions
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

<TestClass>
Public Class ChallengesShould
    <TestMethod>
    Public Sub return_mode()
        Dim results = Challenges.GetMode(1, 2, 3, 3, 4, 4, 5)
        results.Length.Should().Be(2)
        results(0).Should().Be(3)
        results(1).Should().Be(4)
    End Sub

    <TestMethod>
    Public Sub return_encoded_string()
        Dim result = Challenges.GetEncodedString("aaaabbbcca")
        result.Should().Be("4a3b2c1a")
    End Sub

    <TestMethod>
    Public Sub CallApi()
        Dim result = Challenges.CallApi("apple")

    End Sub
End Class

Module Challenges
    Function GetEncodedString(ByVal input As String) As String
        Throw New NotImplementedException()
    End Function

    Function GetMode(ParamArray numbers As Integer()) As Integer()
        Throw New NotImplementedException()
    End Function

    Function CallApi(ByVal word As String) As Object
        'https://dictionaryapi.dev/ 
        'for xml http://api.nbp.pl/api/cenyzlota/last/{topCount}

        Return Nothing
    End Function
End Module



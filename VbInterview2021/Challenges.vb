Imports FluentAssertions
Imports Microsoft.VisualStudio.TestTools.UnitTesting

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
End Class

Module Challenges
    Function GetEncodedString(ByVal input As String) As String
        Throw New NotImplementedException()
    End Function

    Function GetMode(ParamArray numbers As Integer()) As Integer()
        Throw New NotImplementedException()
    End Function
End Module
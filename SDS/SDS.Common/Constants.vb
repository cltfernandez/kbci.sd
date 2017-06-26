
Public Enum RecalculateLedgerResult
    Failed = 0
    Successful = 1
End Enum

Public Enum RecordUpdateResult
    AddSuccessful = 0
    UpdateSuccessful = 1
    Unsuccessful = 2
    RecordExists = 3
End Enum

Public Enum ChangePasswordResult
    IncorrectPassword = 0
    ConfirmPasswordMismatch = 1
    Successful = 2
    Unsuccessful = 3
End Enum

Public Enum DatePickerType
    DateRange = 0
    SingleDate = 1
End Enum

Public Enum MemberSearchType
    MembersData = 0
    SavingsMasterData = 1
End Enum

Public Class TableFieldConstants
    Public Const KbciNumber As String = "KBCI_NO"
    Public Const Name As String = "NAME"
    Public Const LastName As String = "LNAME"
    Public Const Region As String = "REGION"
    Public Const AccountNumber As String = "ACCT_NO"
End Class
Public Class ColumnWidthDefinition
    Public Const MembersGridList As String = "0:100:222:241:38:136:100:0"
    Public Const MembersSearchList As String = "0:100:222:241:38:0"
    Public Const TransactionList As String = "0:0:125:125:110:100:100:210:0:0:60"

End Class
Public Class ColumnAlignmentDefinition
    Public Const MemberGridList As String = "1:2:1:1:1:1:1:1"
    Public Const MembersSearchList As String = "1:1:1:1:1:1"
    Public Const TransactionList As String = "1:1:2:2:1:3:3:1:1:1:2"
End Class

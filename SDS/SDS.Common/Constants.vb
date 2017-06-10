﻿
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

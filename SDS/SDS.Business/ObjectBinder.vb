Imports System.Data.SqlClient
Imports SDS.Entities.SDS.Entities
Imports SDS.DataSource.SDS.DataAccess
Namespace SDS.Business
    Public Class ObjectBinder
        Private dbconn As New db_Database
        Private x As String = ""
        Private ctrl_s_Param As List(Of SqlParameter)
        Private spuser_Param As List(Of SqlParameter)
        Private sdothers_Param As List(Of SqlParameter)
        Private sdmaster_Param As List(Of SqlParameter)
        Public Sub New()

            dbconn.Connectionstring = "Password=" & Utilities.GetConfig("WP") & ";User ID=" & Utilities.GetConfig("CL") & ";Initial Catalog=" & Utilities.GetConfig("DB") & ";Data Source=" & Utilities.GetConfig("SV")
            dbconn.Server = "KBCIDB,1433"
            If dbconn.IsConnected(x) = True Then
                dbconn.Open()
            Else
                Dim ex As New Exception("Unable to connect to database.")
                Throw ex
            End If
        End Sub
#Region "CTRL_S"
        Public Sub bind_CTRL_S(ByRef _ctrl_s As ControlEntity, Optional ByVal filterStr As String = Nothing)
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing

            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            dbconn.GetData("Q_CTRL_S", binderParamList, sqlDR)
            sqlDR.Read()
            With _ctrl_s
                .CTRL_S_ID = Integer.Parse(sqlDR("CTRL_S_ID").ToString)
                .MINBAL = Double.Parse(sqlDR("MINBAL").ToString())
                .ADMDATE = DateValue(sqlDR("ADMDATE").ToString)
                .DBDRM = sqlDR("DBDORMANT").ToString
                .EODF = CBool(sqlDR("EOD_FLAG").ToString)
                .EOMF = CBool(sqlDR("EOM_FLAG").ToString)
                .EOQF = CBool(sqlDR("EOQ_FLAG").ToString)
                .EOYF = CBool(sqlDR("EOY_FLAG").ToString)
                .OTCF = CBool(sqlDR("OTC_FLAG").ToString)
                .SYSDATE = DateValue(sqlDR("SYSDATE").ToString)
            End With
        End Sub

        Public Sub bind_CTRL_S_List(ByRef _ctrl_s_list As ControlList, Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing)
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing

            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            If orderStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@o_Str", orderStr))
            dbconn.GetData("Q_CTRL_S", binderParamList, sqlDR)

            While sqlDR.Read()
                Dim _ctrl_s As New ControlEntity
                With _ctrl_s
                    .CTRL_S_ID = Integer.Parse(sqlDR("CTRL_S_ID").ToString)
                    .MINBAL = Double.Parse(sqlDR("MINBAL").ToString())
                    .ADMDATE = DateValue(sqlDR("ADMDATE").ToString)
                    .DBDRM = sqlDR("DBDORMANT").ToString
                    .EODF = CBool(sqlDR("EOD_FLAG").ToString)
                    .EOMF = CBool(sqlDR("EOM_FLAG").ToString)
                    .EOQF = CBool(sqlDR("EOQ_FLAG").ToString)
                    .EOYF = CBool(sqlDR("EOY_FLAG").ToString)
                    .OTCF = CBool(sqlDR("OTC_FLAG").ToString)
                    .SYSDATE = DateValue(sqlDR("SYSDATE").ToString)
                End With
                _ctrl_s_list.Add(_ctrl_s)
            End While
        End Sub

        Public Sub update_CTRL_S(ByRef _ctrl_s As ControlEntity)
            bind_CTRL_S_Properties(_ctrl_s)
            dbconn.ExecSP("U_CTRL_S", ctrl_s_Param)
        End Sub
        Protected Sub bind_CTRL_S_Properties(ByRef _ctrl_s As ControlEntity)
            Dim rparam As New SqlParameter("@RESULT", SqlDbType.Int)
            rparam.Direction = ParameterDirection.Output
            ctrl_s_Param = New List(Of SqlParameter)
            With _ctrl_s
                ctrl_s_Param.Add(New SqlParameter("@CTRL_S_ID", .CTRL_S_ID))
                ctrl_s_Param.Add(New SqlParameter("@SYSDATE", .SYSDATE))
                ctrl_s_Param.Add(New SqlParameter("@ADMDATE", .ADMDATE))
                ctrl_s_Param.Add(New SqlParameter("@DBDORMANT", .DBDRM))
                ctrl_s_Param.Add(New SqlParameter("@EOD_FLAG", .EODF))
                ctrl_s_Param.Add(New SqlParameter("@EOM_FLAG", .EOMF))
                ctrl_s_Param.Add(New SqlParameter("@EOQ_FLAG", .EOQF))
                ctrl_s_Param.Add(New SqlParameter("@EOY_FLAG", .EOYF))
                ctrl_s_Param.Add(New SqlParameter("@OTC_FLAG", .OTCF))
                ctrl_s_Param.Add(New SqlParameter("@MINBAL", .MINBAL))
            End With
            ctrl_s_Param.Add(rparam)
        End Sub
#End Region
#Region "SPUSER"
        Public Function bind_SPUSER(Optional ByVal filterStr As String = Nothing) As SPUsersEntity
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing

            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            dbconn.GetData("Q_SPUSER", binderParamList, sqlDR)
            If sqlDR.HasRows Then
                sqlDR.Read()
                'With
                '    .SPUSER_ID = Integer.Parse(sqlDR("SPUSER_ID").ToString)
                '    .SPUSERID = sqlDR("SPUSERID").ToString
                '    .SPUSERNAME = sqlDR("SPUSERNAME").ToString
                '    .SPUSERPASS = sqlDR("SPUSERPASS").ToString
                '    .SPUSERPOS = sqlDR("SPUSERPOS").ToString
                '    .SPTELLER = CBool(sqlDR("SPTELLER").ToString)
                '    .SPTAG = sqlDR("SPTAG").ToString
                '    .SPLOGSTAT = CBool(sqlDR("SPLOGSTAT").ToString)
                '    .SPLOGNO = Integer.Parse(sqlDR("SPLOGNO").ToString)
                '    .USER = sqlDR("USER").ToString
                'End With
            End If
        End Function
        Public Function bind_SPUSER_List(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing) As SPUsersList
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing
            Dim spue As New SPUsersList
            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            If orderStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@o_Str", orderStr))
            dbconn.GetData("Q_SPUSER", binderParamList, sqlDR)
            While sqlDR.Read()
                Dim _spuser As New SPUsersEntity
                With _spuser
                    .SPUSER_ID = Integer.Parse(sqlDR("SPUSER_ID").ToString)
                    .SPUSERID = sqlDR("SPUSERID").ToString
                    .SPUSERNAME = sqlDR("SPUSERNAME").ToString
                    .SPUSERPASS = sqlDR("SPUSERPASS").ToString
                    .SPUSERPOS = sqlDR("SPUSERPOS").ToString
                    .SPTELLER = CBool(sqlDR("SPTELLER").ToString)
                    .SPTAG = sqlDR("SPTAG").ToString
                    .SPLOGSTAT = CBool(sqlDR("SPLOGSTAT").ToString)
                    .SPLOGNO = Integer.Parse(sqlDR("SPLOGNO").ToString)
                    .USER = sqlDR("USER").ToString
                End With
                spue.Add(_spuser)
            End While
            Return spue
        End Function
        Public Sub update_SPUSER(ByRef _spuser As SPUsersEntity)
            bind_SPUSER_Properties(_spuser)
            dbconn.ExecSP("U_SPUSER", spuser_Param)
        End Sub
        Protected Sub bind_SPUSER_Properties(ByRef _spuser As SPUsersEntity)
            Dim rparam As New SqlParameter("@RESULT", SqlDbType.Int)
            rparam.Direction = ParameterDirection.Output
            spuser_Param = New List(Of SqlParameter)
            With _spuser
                spuser_Param.Add(New SqlParameter("@SPUSER_ID", .SPUSER_ID))
                spuser_Param.Add(New SqlParameter("@SPUSERID", .SPUSERID))
                spuser_Param.Add(New SqlParameter("@SPUSERNAME", .SPUSERNAME))
                spuser_Param.Add(New SqlParameter("@SPUSERPASS", .SPUSERPASS))
                spuser_Param.Add(New SqlParameter("@SPUSERPOS", .SPUSERPOS))
                spuser_Param.Add(New SqlParameter("@SPTELLER", .SPTELLER))
                spuser_Param.Add(New SqlParameter("@SPTAG", .SPTAG))
                spuser_Param.Add(New SqlParameter("@SPLOGSTAT", .SPLOGSTAT))
                spuser_Param.Add(New SqlParameter("@SPLOGNO", .SPLOGNO))
                spuser_Param.Add(New SqlParameter("@USER", .USER))
            End With
            spuser_Param.Add(rparam)
        End Sub
#End Region
#Region "SDOTHERS"
        Public Sub bind_SDOTHERS(ByRef _sdothers As SDOthersEntity, Optional ByVal filterStr As String = Nothing)
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing

            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            dbconn.GetData("Q_SDOTHERS", binderParamList, sqlDR)
            If sqlDR.HasRows Then
                sqlDR.Read()
                With _sdothers
                    .sdothers_id = Integer.Parse(sqlDR("sdothers_id").ToString)
                    .OthAmount = Double.Parse(sqlDR("OthAmount").ToString)
                    .OthBank = sqlDR("OthBank").ToString
                    .OthChkNo = sqlDR("OthChkNo").ToString
                    .OthDate = DateValue(sqlDR("OthDate").ToString)
                    .OthName = sqlDR("OthName").ToString
                    .OthTime = sqlDR("OthTime").ToString
                    .OthType = sqlDR("OthType").ToString
                    .OthUser = sqlDR("OthUser").ToString
                End With
            End If
        End Sub

        Public Function bind_SDOTHERS_List(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing) As SDOthersList
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing
            Dim sdoe As SDOthersList
            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            If orderStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@o_Str", orderStr))
            dbconn.GetData("Q_SDOTHERS", binderParamList, sqlDR)
            While sqlDR.Read()
                Dim _sdothers As New SDOthersEntity
                With _sdothers
                    .sdothers_id = Integer.Parse(sqlDR("sdothers_id").ToString)
                    .OthAmount = Double.Parse(sqlDR("OthAmount").ToString)
                    .OthBank = sqlDR("OthBank").ToString
                    .OthChkNo = sqlDR("OthChkNo").ToString
                    .OthDate = DateValue(sqlDR("OthDate").ToString)
                    .OthName = sqlDR("OthName").ToString
                    .OthTime = sqlDR("OthTime").ToString
                    .OthType = sqlDR("OthType").ToString
                    .OthUser = sqlDR("OthUser").ToString
                End With
                sdoe.Add(_sdothers)
            End While
            Return sdoe
        End Function

        Protected Sub bind_SDOTHERS_Properties(ByRef _sdothers As SDOthersEntity)
            Dim rparam As New SqlParameter("@RESULT", SqlDbType.Int)
            rparam.Direction = ParameterDirection.Output
            sdothers_Param = New List(Of SqlParameter)
            With _sdothers
                If .sdothers_id > 0 Then sdothers_Param.Add(New SqlParameter("@sdothers_id", .sdothers_id))
                sdothers_Param.Add(New SqlParameter("@OthAmount", .OthAmount))
                sdothers_Param.Add(New SqlParameter("@OthBank", .OthBank))
                sdothers_Param.Add(New SqlParameter("@OthChkNo", .OthChkNo))
                sdothers_Param.Add(New SqlParameter("@OthDate", .OthDate))
                sdothers_Param.Add(New SqlParameter("@OthName", .OthName))
                sdothers_Param.Add(New SqlParameter("@OthTime", .OthTime))
                sdothers_Param.Add(New SqlParameter("@OthType", .OthType))
                sdothers_Param.Add(New SqlParameter("@OthUser", .OthUser))
            End With
            sdothers_Param.Add(rparam)
        End Sub
        Public Sub insert_SDOTHERS(ByRef _sdothers As SDOthersEntity)
            bind_SDOTHERS_Properties(_sdothers)
            dbconn.ExecSP("I_SDOTHERS", sdothers_Param)
            sdothers_Param = Nothing
        End Sub

        Public Sub update_SDOTHERS(ByRef _sdothers As SDOthersEntity)
            bind_SDOTHERS_Properties(_sdothers)
            dbconn.ExecSP("U_SDOTHERS", sdothers_Param)
            sdothers_Param = Nothing
        End Sub
        Public Sub delete_SDOTHERS(ByRef _sdothers As SDOthersEntity)
            Dim rparam As New SqlParameter("@RESULT", SqlDbType.Int)
            rparam.Direction = ParameterDirection.Output
            sdothers_Param = New List(Of SqlParameter)
            sdothers_Param.Add(New SqlParameter("@sdothers_id", _sdothers.sdothers_id))
            sdothers_Param.Add(rparam)
            dbconn.ExecSP("D_SDOTHERS", sdothers_Param)
            sdothers_Param = Nothing
        End Sub
#End Region
#Region "SDMASTER"
        Public Function bind_SDMASTER_List(Optional ByVal filterStr As String = Nothing, Optional ByVal orderStr As String = Nothing) As SDMasterList
            Dim binderParamList As New List(Of SqlParameter)()
            Dim sqlDR As SqlDataReader = Nothing
            Dim sdme As New SDMasterList
            binderParamList.Clear()
            If filterStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@f_Str", filterStr))
            If orderStr IsNot Nothing Then binderParamList.Add(New SqlParameter("@o_Str", orderStr))
            dbconn.GetData("Q_SDMASTER", binderParamList, sqlDR)
            While sqlDR.Read()
                Dim _sdmaster As New SDMasterEntity
                With _sdmaster
                    .SDMASTER_ID = Integer.Parse(sqlDR("SDMASTER_ID").ToString)
                    .ACCTABAL = Double.Parse(sqlDR("ACCTABAL").ToString)
                    .ACCTFLOATS = Double.Parse(sqlDR("ACCTFLOATS").ToString)
                    .ACCTLBAL = Double.Parse(sqlDR("ACCTLBAL").ToString)
                    .ACCTOBAL = Double.Parse(sqlDR("ACCTOBAL").ToString)
                    .ACCTPBAL = Double.Parse(sqlDR("ACCTPBAL").ToString)
                    .HOLDOUT = Double.Parse(sqlDR("HOLDOUT").ToString)
                    .ACCTSTAT = sqlDR("ACCTSTAT").ToString
                    .ACCTNO = sqlDR("ACCTNO").ToString
                    .KBCINO = sqlDR("KBCI_NO").ToString
                    .ACCTNAME = sqlDR("ACCTNAME").ToString
                    .LSEQ = Integer.Parse(sqlDR("LSEQ").ToString)
                    .REC_STAT = Boolean.Parse(sqlDR("REC_STAT").ToString)

                End With
                sdme.Add(_sdmaster)
            End While
            Return sdme
        End Function
        Protected Sub bind_SDMASTER_Properties(ByRef _sdmaster As SDMasterEntity)
            Dim rparam As New SqlParameter("@RESULT", SqlDbType.Int)
            rparam.Direction = ParameterDirection.Output
            sdmaster_Param = New List(Of SqlParameter)
            With _sdmaster
                spuser_Param.Add(New SqlParameter("@SPUSER_ID", .SDMASTER_ID))
                spuser_Param.Add(New SqlParameter("@REC_STAT", .REC_STAT))
            End With
            spuser_Param.Add(rparam)
        End Sub
        Public Sub update_SDMASTER(ByRef _spuser As SDMasterEntity)
            bind_SDMASTER_Properties(_spuser)
            dbconn.ExecSP("U_SDMASTER", spuser_Param)
        End Sub
#End Region

        'Public Function bindRegionalSettings() As RegionalSettingsList
        '    Dim binderParamList As New List(Of SqlParameter)()
        '    Dim rsList As New RegionalSettingsList()
        '    Dim sqlDR As SqlDataReader = Nothing
        '    binderParamList.Clear()
        '    binderParamList.Add(New SqlParameter("@f_Str", "WHERE ACTIVE = 1"))
        '    dbconn.GetData("Q_RESOURCES", binderParamList, sqlDR)
        '    While sqlDR.Read()
        '        Dim rSettings As New RegionalSettings()
        '        rSettings.rs_ResID = Integer.Parse(sqlDR("RESOURCE_ID").ToString())
        '        rSettings.rs_Type = sqlDR("TYPE_TXT").ToString()
        '        rSettings.rs_Name = sqlDR("NAME_TXT").ToString()
        '        rSettings.rs_Desc = sqlDR("DESCRIPTION_TXT").ToString()
        '        rSettings.rs_TimeZone = Integer.Parse(sqlDR("TIMEZONE_INT").ToString())
        '        rSettings.rs_Color = sqlDR("COLOR_TXT").ToString()
        '        rSettings.rs_Constraints = sqlDR("CONSTRAINTS").ToString()
        '        rSettings.rs_Admin1 = sqlDR("ADMIN_PRIMARY_TXT").ToString()
        '        rSettings.rs_Admin2 = sqlDR("ADMIN_SECONDARY_TXT").ToString()
        '        rSettings.rs_CreateDate = sqlDR("CREATED_DT").ToString()
        '        rSettings.rs_CreateBy = sqlDR("CREATED_BY").ToString()
        '        rSettings.rs_UpdateDate = sqlDR("LAST_MOD_BY").ToString()
        '        rSettings.rs_UpdateBy = sqlDR("LAST_MOD_DT").ToString()
        '        rSettings.rs_Active = Convert.ToBoolean(sqlDR("ACTIVE").ToString())
        '        rsList.Add(rSettings)
        '    End While
        '    Return rsList
        'End Function

    End Class
End Namespace
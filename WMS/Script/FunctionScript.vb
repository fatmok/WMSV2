Module FunctionScript

    Public Function GetCountryName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("CountryName", "CountryMaster", "CountryId", SearchItem, "Main")
        Return id
    End Function

    Public Function GetCountryId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("CountryId", "CountryMaster", "CountryName", SearchItem, "Main")
        Return id
    End Function
    Public Function GetAreaName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("AreaName", "AreaMaster", "AreaId", SearchItem, "Main")
        Return id
    End Function
    Public Function CheckIdExist(ByVal SearchField As String, ByVal TableName As String, ByVal SqlVar As String) As Boolean
        Dim v As Boolean = False
        Dim sql As String = "Select " & SearchField & " from " & TableName & " where " & SqlVar
        'MainScript.TestSql(sql)
        Dim dt As DataTable = MainScript.GetDataTable(sql)
        If dt.Rows.Count > 0 Then
            v = True
        End If
        
        Return v

    End Function
    Public Function GetDistrictName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("DistrictName", "DistrictMaster", "DistrictId", SearchItem, "Main")
        Return id
    End Function

    Public Function GetDistrictId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("DistrictId", "DistrictMaster", "DistrictName", SearchItem, "Main")
        Return id
    End Function
    Public Function GetStationName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("StationName", "StationMaster", "StationId", SearchItem, "Main")
        Return id
    End Function

    Public Function GetStationId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("StationId", "StationMaster", "StationName", SearchItem, "Main")
        Return id
    End Function
    Public Function GetAreaId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("AreaId", "AreaMaster", "AreaName", SearchItem, "Main")
        Return id
    End Function
    Public Function GetGarbageSubCatName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("GarbageSubCatName", "GarbageSubCatMaster", "GarbageSubCatId", SearchItem, "Main")
        Return id
    End Function
    Public Function GetGarbageSubCatId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("GarbageSubCatId", "GarbageSubCatMaster", "GarbageSubCatName", SearchItem, "Main")
        Return id
    End Function
    Public Function GetGarbageCatName(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("GarbageCatName", "GarbageCatMaster", "GarbageCatId", SearchItem, "Main")
        Return id
    End Function
    Public Function GetGarbageCatId(ByVal SearchItem As String) As String
        Dim id As String

        id = MainScript.GetDataSql("GarbageCatId", "GarbageCatMaster", "GarbageCatName", SearchItem, "Main")
        Return id
    End Function
End Module

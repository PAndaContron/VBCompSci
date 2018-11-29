<Serializable>
Public Class JavaObject
    Public Property class_name() As String
        Get
            Return m_class_name
        End Get
        Set
            m_class_name = Value
        End Set
    End Property
    Private m_class_name As String
    Public Property serialized_object() As String
        Get
            Return m_serialized_object
        End Get
        Set
            m_serialized_object = Value
        End Set
    End Property
    Private m_serialized_object As String
End Class

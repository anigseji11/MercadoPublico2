Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports Newtonsoft.Json.Converters
Public Class Licit



    Partial Public Class Cabeceras
        <JsonProperty("Cantidad")>
        Public Property Cantidad As Integer
        <JsonProperty("FechaCreacion")>
        Public Property FechaCreacion As DateTime
        <JsonProperty("Version")>
        Public Property Version As String
        <JsonProperty("Listado")>
        Public Property Listado As ListadoDetalle()
    End Class

    Partial Public Class ListadoDetalle
        <JsonProperty("CodigoExterno")>
        Public Property CodigoExterno As String
        <JsonProperty("Nombre")>
        Public Property Nombre As String
        <JsonProperty("CodigoEstado")>
        Public Property CodigoEstado As Integer
        <JsonProperty("Descripcion")>
        Public Property Descripcion As String
        <JsonProperty("FechaCierre")>
        Public Property FechaCierre As DateTime?
        <JsonProperty("Estado")>
        Public Property Estado As String
        <JsonProperty("Comprador")>
        Public Property Comprador As Comprador
        <JsonProperty("DiasCierreLicitacion")>
        Public Property DiasCierreLicitacion As Integer
        <JsonProperty("Informada")>
        Public Property Informada As Boolean
        <JsonProperty("CodigoTipo")>
        Public Property CodigoTipo As Integer
        <JsonProperty("Tipo")>
        Public Property Tipo As String
        <JsonProperty("TipoConvocatoria")>
        Public Property TipoConvocatoria As Long
        <JsonProperty("Moneda")>
        Public Property Moneda As String
        <JsonProperty("Etapas")>
        Public Property Etapas As Long
        <JsonProperty("EstadoEtapas")>
        Public Property EstadoEtapas As Long
        <JsonProperty("TomaRazon")>
        Public Property TomaRazon As Long
        <JsonProperty("EstadoPublicidadOfertas")>
        Public Property EstadoPublicidadOfertas As Long
        <JsonProperty("JustificacionPublicidad")>
        Public Property JustificacionPublicidad As String
        <JsonProperty("Contrato")>
        Public Property Contrato As Long?
        <JsonProperty("Obras")>
        Public Property Obras As Long
        <JsonProperty("CantidadReclamos")>
        Public Property CantidadReclamos As Long
        <JsonProperty("Fechas")>
        Public Property Fechas As Fechas
        <JsonProperty("UnidadTiempoEvaluacion")>
        Public Property UnidadTiempoEvaluacion As Integer?
        <JsonProperty("DireccionVisita")>
        Public Property DireccionVisita As String
        <JsonProperty("DireccionEntrega")>
        Public Property DireccionEntrega As String
        <JsonProperty("Estimacion")>
        Public Property Estimacion As Long?
        <JsonProperty("FuenteFinanciamiento")>
        Public Property FuenteFinanciamiento As String
        <JsonProperty("VisibilidadMonto")>
        Public Property VisibilidadMonto As Long
        <JsonProperty("MontoEstimado")>
        Public Property MontoEstimado As Object
        <JsonProperty("Tiempo")>
        Public Property Tiempo As Object
        <JsonProperty("UnidadTiempo")>
        Public Property UnidadTiempo As Long
        <JsonProperty("Modalidad")>
        Public Property Modalidad As Long
        <JsonProperty("TipoPago")>
        Public Property TipoPago As Long
        <JsonProperty("NombreResponsablePago")>
        Public Property NombreResponsablePago As String
        <JsonProperty("EmailResponsablePago")>
        Public Property EmailResponsablePago As String
        <JsonProperty("NombreResponsableContrato")>
        Public Property NombreResponsableContrato As String
        <JsonProperty("EmailResponsableContrato")>
        Public Property EmailResponsableContrato As String
        <JsonProperty("FonoResponsableContrato")>
        Public Property FonoResponsableContrato As String
        <JsonProperty("ProhibicionContratacion")>
        Public Property ProhibicionContratacion As String
        <JsonProperty("SubContratacion")>
        Public Property SubContratacion As Long
        <JsonProperty("UnidadTiempoDuracionContrato")>
        Public Property UnidadTiempoDuracionContrato As Long
        <JsonProperty("TiempoDuracionContrato")>
        Public Property TiempoDuracionContrato As Long
        <JsonProperty("TipoDuracionContrato")>
        Public Property TipoDuracionContrato As String
        <JsonProperty("JustificacionMontoEstimado")>
        Public Property JustificacionMontoEstimado As String
        <JsonProperty("ObservacionContract")>
        Public Property ObservacionContract As Object
        <JsonProperty("ExtensionPlazo")>
        Public Property ExtensionPlazo As Long
        <JsonProperty("EsBaseTipo")>
        Public Property EsBaseTipo As Long
        <JsonProperty("UnidadTiempoContratoLicitacion")>
        Public Property UnidadTiempoContratoLicitacion As Long
        <JsonProperty("ValorTiempoRenovacion")>
        Public Property ValorTiempoRenovacion As Long
        <JsonProperty("PeriodoTiempoRenovacion")>
        Public Property PeriodoTiempoRenovacion As String
        <JsonProperty("EsRenovable")>
        Public Property EsRenovable As Long
        <JsonProperty("Adjudicacion")>
        Public Property Adjudicacion As PurpleAdjudicacion
        <JsonProperty("Items")>
        Public Property Items As Items
    End Class

    Partial Public Class PurpleAdjudicacion
        <JsonProperty("Tipo")>
        Public Property Tipo As Long?
        <JsonProperty("Fecha")>
        Public Property Fecha As DateTimeOffset?
        <JsonProperty("Numero")>
        Public Property Numero As String
        <JsonProperty("NumeroOferentes")>
        Public Property NumeroOferentes As Long?
        <JsonProperty("UrlActa")>
        Public Property UrlActa As Uri
    End Class

    Partial Public Class Comprador
        <JsonProperty("CodigoOrganismo")>
        Public Property CodigoOrganismo As String
        <JsonProperty("NombreOrganismo")>
        Public Property NombreOrganismo As String
        <JsonProperty("RutUnidad")>
        Public Property RutUnidad As String
        <JsonProperty("CodigoUnidad")>
        Public Property CodigoUnidad As Integer
        <JsonProperty("NombreUnidad")>
        Public Property NombreUnidad As String
        <JsonProperty("DireccionUnidad")>
        Public Property DireccionUnidad As String
        <JsonProperty("ComunaUnidad")>
        Public Property ComunaUnidad As String
        <JsonProperty("RegionUnidad")>
        Public Property RegionUnidad As String
        <JsonProperty("RutUsuario")>
        Public Property RutUsuario As String
        <JsonProperty("CodigoUsuario")>
        Public Property CodigoUsuario As Long
        <JsonProperty("NombreUsuario")>
        Public Property NombreUsuario As String
        <JsonProperty("CargoUsuario")>
        Public Property CargoUsuario As String
    End Class

    Partial Public Class Fechas
        <JsonProperty("FechaCreacion")>
        Public Property FechaCreacion As DateTimeOffset?
        <JsonProperty("FechaCierre")>
        Public Property FechaCierre As Date?
        <JsonProperty("FechaInicio")>
        Public Property FechaInicio As DateTime?
        <JsonProperty("FechaFinal")>
        Public Property FechaFinal As DateTime?
        <JsonProperty("FechaPubRespuestas")>
        Public Property FechaPubRespuestas As DateTime?
        <JsonProperty("FechaActoAperturaTecnica")>
        Public Property FechaActoAperturaTecnica As DateTime?
        <JsonProperty("FechaActoAperturaEconomica")>
        Public Property FechaActoAperturaEconomica As DateTime?
        <JsonProperty("FechaPublicacion")>
        Public Property FechaPublicacion As DateTime?
        <JsonProperty("FechaAdjudicacion")>
        Public Property FechaAdjudicacion As DateTime?
        <JsonProperty("FechaEstimadaAdjudicacion")>
        Public Property FechaEstimadaAdjudicacion As DateTimeOffset?
        <JsonProperty("FechaSoporteFisico")>
        Public Property FechaSoporteFisico As Object
        <JsonProperty("FechaTiempoEvaluacion")>
        Public Property FechaTiempoEvaluacion As Object
        <JsonProperty("FechaEstimadaFirma")>
        Public Property FechaEstimadaFirma As Object
        <JsonProperty("FechasUsuario")>
        Public Property FechasUsuario As Object
        <JsonProperty("FechaVisitaTerreno")>
        Public Property FechaVisitaTerreno As Object
        <JsonProperty("FechaEntregaAntecedentes")>
        Public Property FechaEntregaAntecedentes As Object
    End Class

    Partial Public Class Items
        <JsonProperty("Cantidad")>
        Public Property Cantidad As Long
        <JsonProperty("Listado")>
        Public Property Listado As ItemsListado()
    End Class

    Partial Public Class ItemsListado
        <JsonProperty("Correlativo")>
        Public Property Correlativo As Long
        <JsonProperty("CodigoProducto")>
        Public Property CodigoProducto As Long
        <JsonProperty("CodigoCategoria")>
        Public Property CodigoCategoria As Long
        <JsonProperty("Categoria")>
        Public Property Categoria As String
        <JsonProperty("NombreProducto")>
        Public Property NombreProducto As String
        <JsonProperty("Descripcion")>
        Public Property Descripcion As String
        <JsonProperty("UnidadMedida")>
        Public Property UnidadMedida As String
        <JsonProperty("Cantidad")>
        Public Property Cantidad As Long
        <JsonProperty("Adjudicacion")>
        Public Property Adjudicacion As FluffyAdjudicacion
    End Class

    Partial Public Class FluffyAdjudicacion
        <JsonProperty("RutProveedor")>
        Public Property RutProveedor As String
        <JsonProperty("NombreProveedor")>
        Public Property NombreProveedor As String
        <JsonProperty("Cantidad")>
        Public Property Cantidad As Long
        <JsonProperty("MontoUnitario")>
        Public Property MontoUnitario As Long
    End Class




    End Class

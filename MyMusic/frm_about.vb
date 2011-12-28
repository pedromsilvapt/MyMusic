Public Class frm_about

    Private Sub kllbl_krypton_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kllbl_krypton.LinkClicked
        Process.Start("http://www.componentfactory.com/product?id=3")
    End Sub

    Private Sub kllbl_transitions_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kllbl_transitions.LinkClicked
        Process.Start("http://code.google.com/p/dot-net-transitions/")
    End Sub

    Private Sub kllbl_taglib_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kllbl_taglib.LinkClicked
        Process.Start("http://taglib-sharp.sourcearchive.com/")
    End Sub

    Private Sub kllbl_rating_control_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kllbl_rating_control.LinkClicked
        Process.Start("http://blog.andre-silva.com/2009/05/ratingcontrol-um-controlo-para-ratings-em-net/")
    End Sub

    Private Sub kllbl_fam_fam_fam_icons_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kllbl_fam_fam_fam_icons.LinkClicked
        Process.Start("http://www.famfamfam.com/lab/icons/silk/")
    End Sub

    Private Sub frm_about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.klbl_version.Text = String.Format("Versão {0}", My.Application.Info.Version)
    End Sub
End Class

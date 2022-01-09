# SI_Grupi27_Detyra12

Projekti i tretë në lëndën Siguria në Internet
Titulli: Zhvillimi i aplikacionit që mundëson gjenerimin e PDF fajllit të nënshkruar dhe linkun për verifikim

Ky projekt është realizuar për qëllime sigurie dhe mbrojtje nga ndonjë manipulim i mundshëm gjatë transferimit të dokumenteve të formatit pdf.

## Hapat për shfrytëzimin e aplikacionit
* Klonimi i repository-t
* Krijimi i një 'self-signed digital ID' duke shfrytëzuar Adobe Acrobat DC si në linkun e mëposhtëm:
```
https://helpx.adobe.com/acrobat/using/digital-ids.html#create_a_self_signed_digital_id
```
* Në Microsoft Visual Studio Code nëpërmjet komandës "References > Manage NuGet packages" instalojmë paketën "Aspose.Pdf" që na mundëson libraritë e nevojshme.

![Asposse pdf screen](https://user-images.githubusercontent.com/75142898/148698876-ab885d72-7999-46a4-aabf-e0b247474921.png)

* Me startimin e aplikacionit ngarkojmë PDF fajllin dhe certifikatën
* Pasi kemi shënuar dhe fjalëkalimin e certifikatës nënshkruajmë

![270348986_3045750532343498_5538851380816946044_n](https://user-images.githubusercontent.com/75142898/148700068-e3d0bce9-3891-4d66-852c-c6cead8e2f1b.png)

* Vërejmë nënshkrimin pasi është kryer me sukses:

![image](https://user-images.githubusercontent.com/75142898/148702082-4318dcb8-e378-4f7c-9af1-710bb2f1ec4b.png)

Nënshkrimi:

![image](https://user-images.githubusercontent.com/75142898/148702347-c3a11ebb-ba5d-43bb-919e-f67b47047df9.png)


* Për të verifikuar ngarkojmë PDF fajllin e nënshkruar dhe vërejmë që nënshkrimi është valid:

![image](https://user-images.githubusercontent.com/75142898/148702288-237e0036-4b1d-4d1a-89b0-3813d97548f2.png)


using DynamicMVC.UI.Apps.fishermanager.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB {

    public partial class DBContext : DbContext {

        public DbSet<fsh_fish> fsh_fish { get; set; }
        public DbSet<fsh_fish_type> fsh_fish_type { get; set; }


        //public DbSet<C_FIELD_TYPE> C_FIELD_TYPE { get; set; }
        //public DbSet<C_ISLEM_STANDART_LOG> C_ISLEM_STANDART_LOG { get; set; }
        //public DbSet<C_ISLEM_TANIM_LOG> C_ISLEM_TANIM_LOG { get; set; }
        //public DbSet<C_TABLOLAR> C_TABLOLAR { get; set; }
        //public DbSet<AG> AG { get; set; }
        //public DbSet<AGIRLIK_BIRIMLERI> AGIRLIK_BIRIMLERI { get; set; }
        //public DbSet<AKTIF_DURUM_KOD> AKTIF_DURUM_KOD { get; set; }
        //public DbSet<ANAC_BALIK> ANAC_BALIK { get; set; }

        //public DbSet<AYARLAR> AYARLAR { get; set; }
        //public DbSet<BALIK> BALIK { get; set; }
        //public DbSet<BALIK_BOY_AGIRLIK_ADET> BALIK_BOY_AGIRLIK_ADET { get; set; }
        //public DbSet<BALIK_KULUCKA_SURELERI> BALIK_KULUCKA_SURELERI { get; set; }
        //public DbSet<BALIK_SINIFLARI> BALIK_SINIFLARI { get; set; }
        //public DbSet<BALIK_TUR> BALIK_TUR { get; set; }
        //public DbSet<BILDIRIM_TURLERI> BILDIRIM_TURLERI { get; set; }
        //public DbSet<BIRIM_TURLERI> BIRIM_TURLERI { get; set; }
        //public DbSet<CEVIRI_DILLERI> CEVIRI_DILLERI { get; set; }
        //public DbSet<CEVIRILER> CEVIRILER { get; set; }
        //public DbSet<CIFTLIK> CIFTLIK { get; set; }
        //public DbSet<DEMIRBAS> DEMIRBAS { get; set; }
        //public DbSet<DEMIRBAS_DURUMLARI> DEMIRBAS_DURUMLARI { get; set; }
        //public DbSet<DEMIRBAS_TUR> DEMIRBAS_TUR { get; set; }
        //public DbSet<DOSYA_KATEGORILER> DOSYA_KATEGORILER { get; set; }
        //public DbSet<DOSYA_TURLER> DOSYA_TURLER { get; set; }
        //public DbSet<DOSYALAR> DOSYALAR { get; set; }
        //public DbSet<FIRMA> FIRMA { get; set; }
        //public DbSet<FIRMA_TUR> FIRMA_TUR { get; set; }
        //public DbSet<FORMLAR> FORMLAR { get; set; }
        //public DbSet<GOREV> GOREV { get; set; }
        //public DbSet<HACIM_BIRIMLERI> HACIM_BIRIMLERI { get; set; }
        //public DbSet<HASTALIKLAR> HASTALIKLAR { get; set; }
        //public DbSet<HUCRE> HUCRE { get; set; }
        //public DbSet<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        //public DbSet<ISLEM> ISLEM { get; set; }
        //public DbSet<ISLEM_ADIMLARI> ISLEM_ADIMLARI { get; set; }
        //public DbSet<ISLEM_BALIK_HASAT> ISLEM_BALIK_HASAT { get; set; }
        //public DbSet<ISLEM_KODLARI> ISLEM_KODLARI { get; set; }
        //public DbSet<ISLEM_KULLANICI_ROLLERI> ISLEM_KULLANICI_ROLLERI { get; set; }
        //public DbSet<ISLEM_OLU_BALIK> ISLEM_OLU_BALIK { get; set; }
        //public DbSet<ISLEM_PARAMETRELERI> ISLEM_PARAMETRELERI { get; set; }
        //public DbSet<ISLEM_ROL> ISLEM_ROL { get; set; }
        //public DbSet<ISLEM_TANIM> ISLEM_TANIM { get; set; }
        //public DbSet<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
        //public DbSet<ISLEM_YETKI_ROL> ISLEM_YETKI_ROL { get; set; }
        //public DbSet<ISLEMLER> ISLEMLER { get; set; }
        //public DbSet<KAFES> KAFES { get; set; }
        //public DbSet<KIMYASAL_KURALLARI> KIMYASAL_KURALLARI { get; set; }
        //public DbSet<KIMYASAL_TURLERI> KIMYASAL_TURLERI { get; set; }
        //public DbSet<KIMYASALLAR> KIMYASALLAR { get; set; }
        //public DbSet<KONUM> KONUM { get; set; }
        //public DbSet<KULLANICI> KULLANICI { get; set; }
        //public DbSet<KULLANICI_BILDIRIMLERI> KULLANICI_BILDIRIMLERI { get; set; }
        //public DbSet<KUS_AGI> KUS_AGI { get; set; }
        //public DbSet<KUTUPHANE> KUTUPHANE { get; set; }
        //public DbSet<KUTUPHANE_BAGLANTI> KUTUPHANE_BAGLANTI { get; set; }
        //public DbSet<KUTUPHANE_DOSYA> KUTUPHANE_DOSYA { get; set; }
        //public DbSet<KUTUPHANE_DOSYA_TUR> KUTUPHANE_DOSYA_TUR { get; set; }
        //public DbSet<KUTUPHANE_TURLER> KUTUPHANE_TURLER { get; set; }
        //public DbSet<MENULER> MENULER { get; set; }
        //public DbSet<MESAJLAR> MESAJLAR { get; set; }
        //public DbSet<MEVSIMLER> MEVSIMLER { get; set; }
        //public DbSet<OLAY_TURLERI> OLAY_TURLERI { get; set; }
        //public DbSet<OLAYLAR> OLAYLAR { get; set; }
        //public DbSet<PARA_BIRIM_LOG> PARA_BIRIM_LOG { get; set; }
        //public DbSet<PARA_BIRIMLERI> PARA_BIRIMLERI { get; set; }
        //public DbSet<Pictures> Pictures { get; set; }
        //public DbSet<PLATFORM> PLATFORM { get; set; }
        //public DbSet<PLATFORM_HUCRELERI> PLATFORM_HUCRELERI { get; set; }
        //public DbSet<RAPOR_SABLONLAR> RAPOR_SABLONLAR { get; set; }
        //public DbSet<RAPORLAR> RAPORLAR { get; set; }
        //public DbSet<SEKIL> SEKIL { get; set; }
        //public DbSet<SICAKLIK_YEMLEME_ORANI> SICAKLIK_YEMLEME_ORANI { get; set; }
        //public DbSet<SQL_KODLARI> SQL_KODLARI { get; set; }
        //public DbSet<STOK> STOK { get; set; }
        //public DbSet<STOK_TURLERI> STOK_TURLERI { get; set; }
        //public DbSet<UserLevels> UserLevels { get; set; }
        //public DbSet<UZUNLUK_BIRIMLERI> UZUNLUK_BIRIMLERI { get; set; }
        //public DbSet<YAVRU_BALIK> YAVRU_BALIK { get; set; }
        //public DbSet<YEM> YEM { get; set; }
        //public DbSet<YEM_GELISIM_SURELERI> YEM_GELISIM_SURELERI { get; set; }
        //public DbSet<YEM_KURAL_BOYUT> YEM_KURAL_BOYUT { get; set; }
        //public DbSet<YEM_KURAL_ZAMAN> YEM_KURAL_ZAMAN { get; set; }
        //public DbSet<YEM_TURLERI> YEM_TURLERI { get; set; }
        //public DbSet<YEMLEME_YONTEMLERI> YEMLEME_YONTEMLERI { get; set; }
        //public DbSet<ISLEM_TANIM_VERSIYON> ISLEM_TANIM_VERSIYON { get; set; }
        //public DbSet<PARA_BIRIMI_LOG> PARA_BIRIMI_LOG { get; set; }
        //public DbSet<V_AKTIF_AGLAR> V_AKTIF_AGLAR { get; set; }
        //public DbSet<V_AKTIF_FIRMALAR> V_AKTIF_FIRMALAR { get; set; }
        //public DbSet<V_BAKIM_FIRMALARI> V_BAKIM_FIRMALARI { get; set; }
        //public DbSet<V_BALIK> V_BALIK { get; set; }
        //public DbSet<V_BALIK_SEC> V_BALIK_SEC { get; set; }
        //public DbSet<V_COLUMN_LIST> V_COLUMN_LIST { get; set; }
        //public DbSet<V_COLUMN_LIST_ALL> V_COLUMN_LIST_ALL { get; set; }
        //public DbSet<V_FN_LIST> V_FN_LIST { get; set; }
        //public DbSet<V_HUCRE_OZET> V_HUCRE_OZET { get; set; }
        //public DbSet<V_ISLEM_BALIK_YEMLEME> V_ISLEM_BALIK_YEMLEME { get; set; }
        //public DbSet<V_ISLEM_TANIM_LOG> V_ISLEM_TANIM_LOG { get; set; }
        //public DbSet<V_PLATFORM_OZET> V_PLATFORM_OZET { get; set; }
        //public DbSet<V_SP_LIST> V_SP_LIST { get; set; }
        //public DbSet<V_SYS_TABLOLAR> V_SYS_TABLOLAR { get; set; }
        //public DbSet<V_TABLE_LIST_ALL> V_TABLE_LIST_ALL { get; set; }
        //public DbSet<V_TRIGER_LIST> V_TRIGER_LIST { get; set; }
        //public DbSet<V_VIEW_LIST> V_VIEW_LIST { get; set; }
        //public DbSet<V_YEM> V_YEM { get; set; }
        //public DbSet<V_YEM_KULLANILAN_MIKTAR> V_YEM_KULLANILAN_MIKTAR { get; set; }
        //public DbSet<V_YEM_SATIN_ALINAN_MIKTAR> V_YEM_SATIN_ALINAN_MIKTAR { get; set; }
        //public DbSet<V_YEM_STOK> V_YEM_STOK { get; set; }

    }
}
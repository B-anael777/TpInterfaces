var facture = new Facture("FAC-2026-01", 150.00m);

IImprimable imprimable = facture;
IExportable exportable = facture;

imprimable.Imprimer();
exportable.Exporter("facture.pdf");
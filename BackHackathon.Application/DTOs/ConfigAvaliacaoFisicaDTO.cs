﻿using BackHackathon.Domain.Enums;

namespace BackHackathon.Application.DTOs;

public class ConfigAvaliacaoFisicaDTO
{
    public ETipoUnidadeMedida TipoUnidadeMedidaAltura { get; set; }
    public bool CalculaImc { get; set; }
    public bool CalculaPesoIdeal { get; set; }
    public int QtdeDiasProximaAvaliacao { get; set; }
}
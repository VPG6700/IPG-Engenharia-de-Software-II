# IPG-Engenharia-de-Software-II
Trabalho prático da Unidade Curricular de Engenharia de Software II 

Neste trabalho vamos gerar um escalonamento do transporte (VMER), ou seja, vamos controlar as disponibilidades dos veículos e dos inventários dos equipamentos dentro dos veículos e ausência de enfermeiro e médicos.

Para isso teremos duas entidades que irão gerir o VMER: gestor dos transportes e gestor dos médicos/enfermeiros, disponibilidade dos médicos e enfermeiros, teremos também uma máquina de estados que irá controlar as saídas e entradas dos médicos e enfermeiros e envia os dados para o sistema de horários.

Temos também outros campos tais como: médicos e enfermeiros e veículo enfermeiro. O Veículo (enfermeiro) é uma entidade responsável por relatar ao gestor de transporte, através do sistema de horários, sobre as avarias do veículo, as necessidades de novos inventários dos equipamentos e também sobre a necessidade de manutenção dos veículos.

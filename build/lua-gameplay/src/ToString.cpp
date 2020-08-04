#include "Data.h"

std::ostream &operator<<(std::ostream &os, const BuffS &s) {
    os << "id: " << s.id << " unique_id: " << s.unique_id
       << " maxTime: " << s.maxTime << " restTime: " << s.restTime << " targetId: " << s.targetId << " sourcePawn: "
       << s.sourcePawn << " damage: " << s.damage << " damageType: " << s.damageType << " maxOverlay: " << s.maxOverlay
       << " overlay: " << s.overlay << " primaryOverlay: " << s.primaryOverlay << " value: " << s.value << " baseType: "
       << s.baseType;
    return os;
}

std::ostream &operator<<(std::ostream &os, const PawnS &s) {
    os << "id: " << s.id << " unique_id: " << s.unique_id << " hp: " << s.hp << " mp: " << s.mp << " matk: " << s.matk
       << " atk: " << s.atk << " def: " << s.def << " mdef: " << s.mdef << " buffs: " << s.buffs << " skills: "
       << s.skills << " playerId: " << s.playerId << " type: " << s.type << " posType: " << s.posType << " pos: "
       << s.pos;
    return os;
}

std::ostream &operator<<(std::ostream &os, const SkillS &s) {
    os << "id: " << s.id << " buffs: " << s.buffs << " cost: " << s.cost << " costType: " << s.costType
       << " targetType: " << s.targetType << " sourcePawn: " << s.sourcePawn << " damage: " << s.damage
       << " damageType: " << s.damageType << " passive: " << s.passive << " disperse: " << s.disperse;
    return os;
}

std::ostream &operator<<(std::ostream &os, const PlayerS &s) {
    os << "uid: " << s.uid << " cards: " << s.cards << " pawns: " << s.pawns << " handCards: " << s.handCards
       << " combatCards: " << s.combatCards << " deckCards: " << s.deckCards << " hp: " << s.hp << " maxHp: " << s.maxHp
       << " energy: " << s.energy << " maxEnergy: " << s.maxEnergy << " gold: " << s.gold;
    return os;
}

std::ostream &operator<<(std::ostream &os, const PawnD &d) {
    os << "id: " << d.id << " unique_id: " << d.unique_id << " hp: " << d.hp << " mp: " << d.mp << " matk: " << d.matk
       << " atk: " << d.atk << " def: " << d.def << " mdef: " << d.mdef << " playerId: " << d.playerId << " type: "
       << d.type << " posType: " << d.posType << " pos: " << d.pos;
    return os;
}

std::ostream &operator<<(std::ostream &os, const Damage &damage) {
    os << "isHeal: " << damage.isHeal << " value: " << damage.value << " curValue: " << damage.curValue
       << " damageType: " << damage.damageType << " curDamageType: " << damage.curDamageType << " source: "
       << damage.source << " target: " << damage.target;
    return os;
}

std::ostream &operator<<(std::ostream &os, const AttrStruct &aStruct) {
    os << "combatId: " << aStruct.combatId << " playerId: " << aStruct.playerId << " objectId: " << aStruct.objectId
       << " value: " << aStruct.value << " type: " << aStruct.type;
    return os;
}

std::ostream &operator<<(std::ostream &os, const Config &config) {
    os << "normalDrawPrice: " << config.normalDrawPrice << " highDrawPrice: " << config.highDrawPrice
       << " normal_nPercent: " << config.normal_nPercent << " normal_rPercent: " << config.normal_rPercent
       << " normal_srPercent: " << config.normal_srPercent << " normal_ssrPercent: " << config.normal_ssrPercent
       << " high_nPercent: " << config.high_nPercent << " high_rPercent: " << config.high_rPercent
       << " high_srPercent: " << config.high_srPercent << " high_ssrPercent: " << config.high_ssrPercent
       << " primaryGold: " << config.primaryGold << " salary: " << config.salary << " roundCard: " << config.roundCard
       << " primaryCard: " << config.primaryCard << " maxRound: " << config.maxRound << " primaryEnergy: "
       << config.primaryEnergy << " energyGrow: " << config.energyGrow << " maxEnergy: " << config.maxEnergy
       << " primaryHp: " << config.primaryHp << " maxHp: " << config.maxHp;
    return os;
}

std::ostream &operator<<(std::ostream &os, const BuffD &d) {
    os << "id: " << d.id << " restTime: " << d.restTime << " unique_id: " << d.unique_id << " overlay: " << d.overlay;
    return os;
}
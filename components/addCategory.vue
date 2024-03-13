<template>
  <div v-if="buttonFlag" class="add-category-button" @click="clickButton()">＋New category</div>
  <div v-if="formFlag" class="imput-form">
    <input v-model="categoryName" class="add-category-form" placeholder="Category Name" />
    <div class="decision-button" @click="addCategory(categoryName)">Add</div>
  </div>
</template>

<script setup lang="ts">
// 変数宣言
const buttonFlag = ref(true);
const formFlag = ref(false);
const categoryName = ref("");

// Emit定義
const emit = defineEmits<{
  (e: "onClick", newCategory?: string): void;
}>();
const addCategory = (newCategory?: string): void => {
  if (newCategory != null && newCategory != "") {
    buttonFlag.value = true;
    formFlag.value = false;
    categoryName.value = "";
    emit("onClick", newCategory);
  }
};

// カテゴリー追加ボタンを押したときの動作
const clickButton = (): void => {
  buttonFlag.value = false;
  formFlag.value = true;
};
</script>

<style scoped>
.add-category-button {
  cursor: pointer;
  display: inline-flex;
  flex-direction: column;
  font-size: 18px;
  color: var(--font-gray);
}

.imput-form {
  display: flex;
  width: auto;
  gap: 10px;
  align-items: center;
}

.add-category-form {
  width: 120px;
  font-size: 15px;
  height: 25px;
  border: 2px solid var(--border-gray);
  padding: 2px 7px;
}

.add-category-form:focus {
  border: 2px solid var(--border-blue);
  z-index: 10;
  outline: none;
}

.decision-button {
  cursor: pointer;
  font-size: 18px;
  height: 25px;
  width: 50px;
  border-radius: 50px;
  border: 2px solid var(--border-black);
  text-align: center;
}

.decision-button:hover {
  border: 2px solid var(--border-blue);
  color: var(--font-blue);
  z-index: 10;
  outline: none;
}
</style>
